using HorsePowerStore.Data;
using HorsePowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class CarsService
    {
        private ApplicationDbContext db;

        public CarsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<string> ListMakes ()
        {
            return (
                from c in db.Cars
                group c by c.Make into cGroup
                select cGroup.Key).ToList();
        }

        public List<string> ListMakeModels(string make)
        {
            return (
                from c in db.Cars
                where c.Make == make
                group c by c.Model into cGroup
                select cGroup.Key).ToList();
        }

        public List<int> ListModelYears(string model)
        {
            return (
                from c in db.Cars
                where c.Model == model
                group c by c.Year into cGroup
                select cGroup.Key).ToList();
        }

        public List<_Car> ListFiltered (string make, string model, int year)
        {
            List<_Car> newCars = new List<_Car> { };

            var tempCars = (
                from c in db.Cars
                where
                    c.Make == make &&
                    c.Model == model &&
                    c.Year == year
                select c).Include(c => c.CompatibleEngines).ToList();

            for (var x = 0; x < tempCars.Count; x++)
            {

                var holder = new _Car 
                {
                    Id = tempCars[x].Id,
                    Make = tempCars[x].Make,
                    Model = tempCars[x].Model,
                    Year = tempCars[x].Year,
                    Doors = tempCars[x].Doors,
                    Drive = Enum.GetName(typeof(Drive), tempCars[x].Drive),
                    Transmission = Enum.GetName(typeof(Transmission), tempCars[x].Transmission),
                    Fuel = Enum.GetName(typeof(Fuel), tempCars[x].Fuel),
                    CompatibleEngines = tempCars[x].CompatibleEngines
                };
                newCars.Add(holder);
            }

            return newCars;
        }
    }
}
