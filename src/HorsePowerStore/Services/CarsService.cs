using HorsePowerStore.Data;
using HorsePowerStore.Models;
using HorsePowerStore.ViewModels;
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
                from m in db.Makes
                select m.Name).ToList();
        }

        public IEnumerable<string> ListMakeModels(string makeName)
        {
            return (
                from m in db.Makes
                where m.Name == makeName
                select m.Models.Select(mo => mo.Name))
                .FirstOrDefault();
        }

        public IEnumerable<int> ListModelYears(string modelName)
        {
            return (
                from mo in db.Models
                where mo.Name == modelName
                select mo.Years.Select(y => y.Years))
                .FirstOrDefault();
        }

        public StylesViewModel GetStyles (string makeName, string modelName, int year)
        {
            List<CarViewModel> newCars = new List<CarViewModel>();

            Make make = (
                from m in db.Makes
                where m.Name == makeName
                select new Make
                {
                    Id = m.Id,
                    Name = m.Name,
                    Models = (
                        from mo in m.Models
                        where mo.Name == modelName
                        select new Model
                        {
                            Id = mo.Id,
                            Name = mo.Name,
                            Years = (
                                from y in mo.Years
                                where y.Years == year
                                select new Year
                                {
                                    Id = y.Id,
                                    Years = y.Years,
                                    Styles = y.Styles
                                }
                            ).ToList()
                        }
                    ).ToList()
                }).ToList().FirstOrDefault();

            if (make == null) return new StylesViewModel();

            Model model = make.Models.FirstOrDefault();
            if (model == null) return new StylesViewModel();

            Year yearObj = model.Years.FirstOrDefault();
            if (yearObj == null) return new StylesViewModel();

            foreach (var style in yearObj.Styles)
            {
                newCars.Add(new CarViewModel
                {
                    Id = make.Id,
                    Make = make.Name,
                    Year = yearObj.Years,
                    Name = style.Name
                });
            };

            return new StylesViewModel
            {
                Styles = newCars
            };
        }
    }
}
