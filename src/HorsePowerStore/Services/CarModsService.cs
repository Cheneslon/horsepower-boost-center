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

        public List<CarMod> ListCarModsByEngine(int engineId, int start, int amount)
        {
            var engine = (
                from e in db.Engines
                where e.Id == engineId
                select e).FirstOrDefault();

            return (
                from cm in db.CarMods
                where cm.Engine == engine
                select cm).Include(cm => cm.Product)
                .Skip(start).Take(amount).ToList();
        }
    }
}
