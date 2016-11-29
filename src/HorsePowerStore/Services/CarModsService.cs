using HorsePowerStore.Data;
using HorsePowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class CarModsService
    {
        private ApplicationDbContext db;

        public CarModsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<CarMod> ListCarModsByEngine(string style, int start, int amount)
        {
            var Style = (
                from e in db.Styles
                where e.Name == style.ToString()
                select e).FirstOrDefault();
            Console.WriteLine();
            return (
                from cm in db.CarMods
                where cm.Style == Style
                select cm).Include(cm => cm.Product)
                .Skip(start).Take(amount).ToList();
        }
    }
}
