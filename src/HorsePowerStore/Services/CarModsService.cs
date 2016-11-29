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

        public List<Product> ListProductsByStyle(int styleId, int start, int amount)
        {
            var style = (
                from s in db.Styles
                where s.Id == styleId
                select s)
                .FirstOrDefault();

            return (
                from cm in db.CarMods
                where cm.Style == style
                select cm.Product)
                .Skip(start).Take(amount).ToList();
        }
    }
}
