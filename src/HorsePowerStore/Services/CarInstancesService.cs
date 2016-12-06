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

        public CarInstance Get (int id, string userName)
        {
            var user = (
                from u in appDbContext.AppUsers
                    .Include(u => u.CarInstances)
                    .ThenInclude(ci => ci.SelectedCarMods)
                    .ThenInclude(cms => cms.CarMod)
                    .ThenInclude(cm => cm.Product)
                    .Include(u => u.CarInstances)
                    .ThenInclude(ci => ci.Style)
                where u.UserName == userName
                select u)
                .FirstOrDefault();
            if (user == null) return null;

            return user.CarInstances
                .Where(ci => ci.Id == id)
                .FirstOrDefault();
        }

        public void Overwrite(CarInstance carInstance, string userName)
        {
            var user = GetUser(userName);
            var selectedCarInstance = user.CarInstances
                .Where(ci => ci.Id == carInstance.Id)
                .FirstOrDefault();
            if (selectedCarInstance == null) return;

            var ids = carInstance.SelectedCarMods
                .Select(scm => scm.CarMod.Id)
                .ToList();

            var dbCarMods = (
                from cm in appDbContext.CarMods
                where ids.Contains(cm.Id)
                select cm)
                .Select(cm => new CarModSelection {
                    CarMod = cm
                })
                .ToList();

            selectedCarInstance = (
                from ci in appDbContext.CarInstances
                where ci.Id == selectedCarInstance.Id
                select ci)
                .Include(ci => ci.SelectedCarMods).First();

            selectedCarInstance.SelectedCarMods.RemoveAll(scm => true);
            selectedCarInstance.SelectedCarMods = dbCarMods;
            appDbContext.SaveChanges();
        }

        public void Save (CarInstance carInstance, string userName, ApplicationUser user=null)
        {
            if (user == null) user = GetUser(userName);
            if (user.CarInstances.Any(ci => ci.Id == carInstance.Id)) return;

            user.CarInstances.Add(carInstance);
            appDbContext.CarInstances.Add(carInstance);
            appDbContext.CarModSelections.AddRange(carInstance.SelectedCarMods);

            appDbContext.CarMods
                .AttachRange(
                    carInstance.SelectedCarMods
                    .Select(scm => scm.CarMod));
            appDbContext.Products
                .AttachRange(
                    carInstance.SelectedCarMods
                    .Select(scm => scm.CarMod.Product));
            appDbContext.Styles.Attach(carInstance.Style);

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
