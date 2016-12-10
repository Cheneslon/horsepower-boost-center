using HorsePowerStore.Data;
using HorsePowerStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class UserService
    {
        private ApplicationDbContext appDbContext;

        public UserService (ApplicationDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void Delete (string userName)
        {
            var user = appDbContext.Users
                .Include(u => u.Ratings)
                .Include(u => u.CarInstances)
                .ThenInclude (ci => ci.SelectedCarMods)
                .SingleOrDefault(u => u.UserName == userName);
            
            appDbContext.Ratings.RemoveRange(user.Ratings);
            appDbContext.CarModSelections
                .RemoveRange(
                    user.CarInstances
                        .SelectMany(ci => ci.SelectedCarMods));
            appDbContext.CarInstances.RemoveRange(user.CarInstances);
            appDbContext.Users.Remove(user);
            appDbContext.SaveChanges();
        }
    }
}
