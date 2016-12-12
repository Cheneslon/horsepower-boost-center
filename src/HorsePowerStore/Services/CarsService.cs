using HorsePowerStore.Data;
using HorsePowerStore.Models;
using HorsePowerStore.ViewModels;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class CarsService
    {
        private ApplicationDbContext db;
        private EdmundsService edmundsService;


        public CarsService(
            ApplicationDbContext db,
            EdmundsService edmundsService)
        {
            this.db = db;
            this.edmundsService = edmundsService;
        }

        public async Task<IEnumerable<string>> ListMakes ()
        {
            return (
                from m in db.Makes
                select m.Name)
                .Concat(await edmundsService.ListMakes())
                .ToList()
                .Distinct()
                .OrderBy(str => str);
        }

        public async Task<IEnumerable<string>> ListMakeModels(string makeName)
        {
            return (
                from m in db.Makes
                from mo in m.Models
                where m.Name == makeName
                select mo.Name)
                .Concat(await edmundsService.ListMakeModels(makeName))
                .ToList()
                .Distinct()
                .OrderBy(str => str);
        }

        public async Task<IEnumerable<int>> ListModelYears(string modelName)
        {
             return (
                from mo in db.Models
                from y in mo.Years
                where mo.Name == modelName
                select y.Years)
                .Concat(await edmundsService.ListModelYears(modelName))
                .ToList()
                .Distinct()
                .OrderBy(i => i);
        }

        public async Task<StylesViewModel> GetStyles (string makeName, string modelName, int year)
        {
            var result = await edmundsService.GetStyles(makeName, modelName, year);

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
                                })
                                .ToList()
                        })
                        .ToList()
                })
                .ToList()
                .FirstOrDefault();

            if (make == null) return result;
            Model model = make.Models.FirstOrDefault();
            if (model == null) return result;
            Year styleYear = model.Years.FirstOrDefault();
            if (styleYear == null) return result;

            result.Styles.AddRange(
                from s in styleYear.Styles
                select new StyleViewModel
                {
                    Id = make.Id,
                    Make = make.Name,
                    Year = styleYear.Years,
                    Name = s.Name
                });

            return result;
        }
    }
}
