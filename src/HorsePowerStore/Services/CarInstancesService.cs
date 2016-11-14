using HorsePowerStore.Data;
using HorsePowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class CarInstancesService
    {
        private ApplicationDbContext appDbContext;

        private ApplicationUser GetUser (string name)
        {
            return (
                from u in appDbContext.AppUsers
                where u.UserName == name
                select u)
                .Include(u => u.CarInstances)
                .FirstOrDefault();
        }

        public CarInstancesService (ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Save (CarInstance instance, string userName)
        {
            GetUser(userName).CarInstances.Add(instance);
            appDbContext.SaveChanges();
        }

        public void Delete(int instanceId, string userName)
        {
            GetUser(userName).CarInstances.Remove((
                    from ci in appDbContext.CarInstances
                    where ci.Id == instanceId
                    select ci)
                .FirstOrDefault());
            appDbContext.SaveChanges();
        }

        public List<CarInstance> GetUserSaved (string userName)
        {
            return GetUser(userName).CarInstances;
        }
    }
}
