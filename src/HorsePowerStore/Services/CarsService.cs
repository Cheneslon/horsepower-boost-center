using HorsePowerStore.Data;
using HorsePowerStore.Models;
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

        public List<Car> ListFiltered (string make, string model, int year)
        {
            return (
                from c in db.Cars
                where 
                    c.Make == make && 
                    c.Model == model && 
                    c.Year == year
                select c).ToList();
        }
    }
}
