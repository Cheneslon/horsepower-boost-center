using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using HorsePowerStore.Models;

namespace HorsePowerStore.Data
{
    public class SampleData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();

            // Ensure db
            context.Database.EnsureCreated();
            
            if (!context.Engines.Any())
            {
                context.Engines.AddRange(
                    new Engine
                    {
                        //Id = 1,
                        Cylinders = 4,
                        Volume = 100,
                        Intake = 100,
                        HorsePower = 100
                    },
                    new Engine
                    {
                        //Id = 2,
                        Cylinders = 4,
                        Volume = 200,
                        Intake = 200,
                        HorsePower = 200
                    }
                    );
                context.SaveChanges();

            }

            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car
                    {
                        //Id = 1,
                        Make = "Honda",
                        Model = "Accord",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.TwoWheel,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.Engines.ToList()

                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Honda",
                        Model = "Civic",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.TwoWheel,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.Engines.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "BMW",
                        Model = "X1",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.TwoWheel,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.Engines.ToList()
                    }
                );
                context.SaveChanges();
            }


            // Ensure Stephen (IsAdmin)
            var stephen = await userManager.FindByNameAsync("Stephen.Walther@CoderCamps.com");
            if (stephen == null)
            {
                // create user
                stephen = new ApplicationUser
                {
                    UserName = "Stephen.Walther@CoderCamps.com",
                    Email = "Stephen.Walther@CoderCamps.com"
                };
                await userManager.CreateAsync(stephen, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(stephen, new Claim("IsAdmin", "true"));
            }

            // Ensure Mike (not IsAdmin)
            var mike = await userManager.FindByNameAsync("Mike@CoderCamps.com");
            if (mike == null)
            {
                // create user
                mike = new ApplicationUser
                {
                    UserName = "Mike@CoderCamps.com",
                    Email = "Mike@CoderCamps.com"
                };
                await userManager.CreateAsync(mike, "Secret123!");
            }


        }

    }
}
