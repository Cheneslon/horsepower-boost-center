using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using HorsePowerStore.Controllers;
using HorsePowerStore.API;
using HorsePowerStore.Services;
using HorsePowerStore.Data;
using Microsoft.EntityFrameworkCore;
using HorsePowerStore.Models;
using System.Security.Principal;
using System.Threading;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using HorsePowerStore.ViewModels;
using HorsePowerStore.ServiceSettings;
using System.IO;
using Microsoft.Extensions.Options;
using Moq;

namespace HorsePowerStore.UnitTests
{
    [TestFixture]
    public class ControllerTest
    {
        // Use separate DbContextOptions for each test to avoid data collisions
        private DbContextOptions<ApplicationDbContext> CreateOptions (string name) {
            return new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: name)
                .Options;
        }

        [Test]
        public void ProductsCrud ()
        {
            var options = CreateOptions("ProductsCrud");

            using (var context = new ApplicationDbContext(options))
            {
                var controller =
                    new ProductsController(
                        new ProductsService(
                            context));

                Assert.That(
                    controller.ListProducts(0).Count == 0,
                    "Test database should be empty, but found at least one product");

                // Products per page == 50, adding 51 products means we should be able
                // to access one full page and one partial page through the controller
                for (int i = 0; i < 51; i++)
                {
                    controller.AddProduct(new Product
                    {
                        Name = "Test",
                        Description = "Unit Test Product",
                        Price = i * 5
                    });
                }
            }

            using (var context = new ApplicationDbContext(options))
            {
                var controller =
                    new ProductsController(
                        new ProductsService(
                            context));

                Assert.That(
                    controller.ListProducts(0).Count == 50,
                    "Number of products on first page is not 50 when controller " +
                    "page length is  and there are at least 50 products in the database. " +
                    "Has the page length changed?");
                Assert.That(
                    controller.ListProducts(1).Count == 1,
                    "Number of products on second page is not one when there are " +
                    "51 products in the data base and there are 50 products per page. " +
                    "Has the page length changed?");
            }
        }

        [Test]
        public void RatingsCrud ()
        {
            var options = CreateOptions("RatingsCrud");

            using (var context = new ApplicationDbContext((options)))
            {
                var controller =
                    new ProductsController(
                        new ProductsService(
                            context));

                Assert.That(
                    controller.ListProducts(0).Count == 0,
                    "Test database should be empty, but found at least one product");

                var product = new Product()
                {
                    Name = "Rated Product Test",
                    Description = "Rated Product Test"
                };
                context.Products.Add(product);

                var users = new List<ApplicationUser>()
                {
                    new ApplicationUser ()
                    {
                        UserName = "Alice"
                    },
                    new ApplicationUser ()
                    {
                        UserName = "Bob"
                    }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            using (var context = new ApplicationDbContext(options))
            {
                var controller =
                    new ProductsController(
                        new ProductsService(
                            context));

                // Default identity to avoid NullReferenceException
                controller.ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                    {
                        User = new ClaimsPrincipal (new ClaimsIdentity())
                    }
                };

                var id = context.Products.First().Id;
                var productViewModel = controller.GetProductWithRatings(id, 0);
                Assert.That(
                    productViewModel.AverageRating == 0,
                    "Product has no ratings, but a non-zero average rating.");
                Assert.That(productViewModel.UserRating == 0,
                    "User has not rated product, but user rating is reported to be non-zero.");
                
                // "Logging in" user 
                controller.ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                    {
                        User = new ClaimsPrincipal(
                            new ClaimsIdentity(
                                new Claim[]
                                {
                                     new Claim(ClaimTypes.Name, "Alice")
                                }))
                    }
                };
                
                
                controller.AddRating(new RatingViewModel {
                    Message = "Test rating",
                    ProductId = id,
                    UserName = "Alice",
                    Value = 5
                });

                productViewModel = controller.GetProductWithRatings(id, 0);
                Assert.That(
                    productViewModel.UserRating == 5,
                    "User has given product rating value of 5, but UserRating is not 5.");
                Assert.That(productViewModel.AverageRating == 5, 
                    "Product has only one rating with a value of 5, but AverageRating is not 5.");

                // "Log in" as different user
                controller.ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                    {
                        User = new ClaimsPrincipal(
                            new ClaimsIdentity(
                                new Claim[]
                                {
                                     new Claim(ClaimTypes.Name, "Bob")
                                }))
                    }
                };

                productViewModel = controller.GetProductWithRatings(id, 0);
                Assert.That(
                    productViewModel.UserRating == 0,
                    "User has not rated product, but user rating is reported to be non-zero.");
                Assert.That(productViewModel.AverageRating == 5,
                    "Product has only one rating with a value of 5, but AverageRating is not 5.");

                controller.AddRating(new RatingViewModel
                {
                    Message = "Test rating",
                    ProductId = id,
                    UserName = "Bob",
                    Value = 4
                });
                
                productViewModel = controller.GetProductWithRatings(id, 0);
                Assert.That(productViewModel.UserRating == 4,
                    "User has given product rating value of 4, but UserRating is not 4");
                Assert.That(productViewModel.AverageRating == 4.5,
                    "Product has two ratings total, with values of 4 and 5, but the product's" +
                    "average rating is not reported as 4.5.");

                // Log out
                controller.ControllerContext = new ControllerContext() {
                    HttpContext = new DefaultHttpContext()
                };
                
                productViewModel = controller.GetProductWithRatings(id, 0);
                Assert.That(
                    productViewModel.UserRating == 0,
                    "User is not logged in, but product's user rating is reported as non-zero");
                Assert.That(productViewModel.AverageRating == 4.5,
                    "Product has two ratings total, with values of 4 and 5, but the product's" +
                    "average rating is not reported as 4.5.");
            }
        } 

        [Test]
        public async Task EdmundsApiAccess ()
        {
            var options = CreateOptions("EdmundsApiAccess");

            // Note: configuration requires that the appsettings.json file and 
            // UserSecretsId (in project.json) are included in the UnitTest project
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddUserSecrets()
                .AddEnvironmentVariables()
                .Build();

            var edmundsSettings = new EdmundsSettings()
            {
                EdmundsApiKey = configuration["EdmundsApiKey"]
            };

            var optionsMock = new Mock<IOptions<EdmundsSettings>>();
            optionsMock.Setup(m => m.Value).Returns(edmundsSettings);

            using (var context = new ApplicationDbContext(options))
            {
                var carsController = new CarsController(
                    new CarsService(
                        context,
                        new EdmundsService(optionsMock.Object)));

                Assert.That(
                    (await carsController.ListMakes()).Count() > 0,
                    "No makes retrieved from Edmunds.");
            }
        }
    }
}
