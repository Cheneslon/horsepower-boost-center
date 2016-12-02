﻿using HorsePowerStore.Data;
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
            var result = (
                from u in appDbContext.AppUsers
                    .Include(u => u.CarInstances)
                    .ThenInclude(ci => ci.SelectedProducts)
                    .ThenInclude(ps => ps.Product)
                    .Include(u => u.CarInstances)
                    .ThenInclude (ci => ci.Style)
                where u.UserName == userName
                select u)
                .FirstOrDefault();

            return result.CarInstances
                .Where(ci => ci.Id == id)
                .FirstOrDefault();
        }

        public void Save (CarInstance instance, string userName)
        {
            GetUser(userName).CarInstances.Add(instance);
            appDbContext.Products.AttachRange(
                instance.SelectedProducts
                .Select(sp => sp.Product));
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
