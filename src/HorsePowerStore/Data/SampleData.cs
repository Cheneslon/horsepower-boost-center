using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using HorsePowerStore.Models;
using System.Collections.Generic;

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

            if (!context.Makes.Any())
            {




                List<Model> BMWModels = new List<Model>() {
                    new Model
                    {
                        Name = "X1"
                    }
                    };


                List<Model> FordModels = new List<Model>()
                {


                };
                List<Model> DodgeModels = new List<Model>()
                {


                };
                List<Model> PontiacModels = new List<Model>()
                {


                };
                List<Model> AMCModels = new List<Model>()
                {


                }; List<Model> PlymouthModels = new List<Model>()
                {


                };
                List<Model> MercuryModels = new List<Model>()
                {


                };
                List<Model> OldsmobileModels = new List<Model>()
                {


                };
                context.Makes.AddRange(
                    new Make
                    {
                        Name = "Honda",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "Accord"
                            },
                            new Model
                            {
                                Name = "Civic"
                            }
                        }
                    },
                    new Make
                    {
                        Name = "BMW",
                        Models = BMWModels
                    },
                    new Make
                    {
                        Name = "Chevrolet",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "Monte Carlo",
                                Years = new List<Year>()
                                {
                                    new Year
                                    {
                                        Years = 1970
                                    },
                                    new Year
                                    {
                                        Years = 1971
                                    },
                                    new Year
                                    {
                                        Years = 1972
                                    },
                                    new Year
                                    {
                                        Years = 1973
                                    },
                                    new Year
                                    {
                                        Years = 1974
                                    },
                                    new Year
                                    {
                                        Years = 1975
                                    },
                                    new Year
                                    {
                                        Years = 1976
                                    },
                                    new Year
                                    {
                                        Years = 1977
                                    },
                                    new Year
                                    {
                                        Years = 1978
                                    },
                                    new Year
                                    {
                                        Years = 1979
                                    },
                                    new Year
                                    {
                                        Years = 1980
                                    },
                                    new Year
                                    {
                                        Years = 1981
                                    },
                                    new Year
                                    {
                                        Years = 1982
                                    },
                                    new Year
                                    {
                                        Years = 1983
                                    },
                                    new Year
                                    {
                                        Years = 1984
                                    },
                                    new Year
                                    {
                                        Years = 1985
                                    },
                                    new Year
                                    {
                                        Years = 1986
                                    },
                                    new Year
                                    {
                                        Years = 1987
                                    },
                                    new Year
                                    {
                                        Years = 1988
                                    }
                                }
                            },
                            new Model
                            {
                                Name = "Corvette",
                                Years = new List<Year>()
                                {
                                     new Year
                                    {
                                        Years = 1953,
                                        Styles = new List<Style>(){
                                            new Style {
                                                Name = "2dr Covertible(235ci 6cyl 2A)",
                                                Horsepower = 150
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1954,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible(235ci 2A)",
                                                 Horsepower = 150
                                            }
                                        }
                                    },
                                    new Year
                                    {
                                        Years = 1955,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Convertible (235ci 6cyl 2A)",
                                                Horsepower = 155
                                            },
                                            new Style
                                            {
                                                Name ="2dr Convertible (265ci 8cyl 3M)",
                                                 Horsepower = 195
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1956,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Convertible (265ci 8cyl)",
                                                 Horsepower = 210
                                            },
                                            new Style
                                            {
                                                Name ="2dr Convertible (265ci 8cyl)",
                                                 Horsepower = 225
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (265ci 8cyl)",
                                                 Horsepower = 240
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1957,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)",
                                                Horsepower = 220
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 250
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 283
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1958,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 290
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1959,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 290
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1960,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 290
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1961,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 275
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 315
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1962,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name ="2dr Covertible (327ci 8cyl 3M)",
                                                Horsepower = 250
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 275
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 4M)",
                                                Horsepower = 315
                                            }
                                         }
                                    }, new Year
                                    {
                                        Years = 1963
                                    }, new Year
                                    {
                                        Years = 1964
                                    }, new Year
                                    {
                                        Years = 1965
                                    }, new Year
                                    {
                                        Years = 1966
                                    },
                                      new Year
                                    {
                                        Years = 1967
                                    }, new Year
                                    {
                                        Years = 1968
                                    }, new Year
                                    {
                                        Years = 1969
                                    },
                                    new Year
                                    {
                                        Years = 1970
                                    },
                                    new Year
                                    {
                                        Years = 1971
                                    },
                                    new Year
                                    {
                                        Years = 1972
                                    },
                                    new Year
                                    {
                                        Years = 1973
                                    },
                                    new Year
                                    {
                                        Years = 1974
                                    },
                                    new Year
                                    {
                                        Years = 1975
                                    },
                                    new Year
                                    {
                                        Years = 1976
                                    },
                                    new Year
                                    {
                                        Years = 1977
                                    },
                                    new Year
                                    {
                                        Years = 1978
                                    },
                                    new Year
                                    {
                                        Years = 1979
                                    },
                                    new Year
                                    {
                                        Years = 1980
                                    },
                                    new Year
                                    {
                                        Years = 1981
                                    },
                                    new Year
                                    {
                                        Years = 1982
                                    },
                                    new Year
                                    {
                                        Years = 1983
                                    },
                                    new Year
                                    {
                                        Years = 1984
                                    },
                                    new Year
                                    {
                                        Years = 1985
                                    },
                                    new Year
                                    {
                                        Years = 1986
                                    },
                                    new Year
                                    {
                                        Years = 1987
                                    },
                                    new Year
                                    {
                                        Years = 1988
                                    },
                                    new Year
                                    {
                                        Years = 1989
                                    }

                                }

                            }
                        }
                    },
                    new Make
                    {
                        Name = "Ford",
                        Models = FordModels
                    },
                    new Make
                    {
                        Name = "Pontiac",
                        Models = PontiacModels
                    },new Make
                    {
                        Name = "Dodge",
                        Models = DodgeModels
                    },
                    new Make
                    {
                        Name = "AMC",
                        Models = AMCModels
                    },
                    new Make
                    {
                        Name = "Plymouth",
                        Models = PlymouthModels
                    },
                    new Make
                    {
                        Name = "Mercury",
                        Models = MercuryModels
                    },
                    new Make
                    {
                        Name = "Oldsmobile",
                        Models = OldsmobileModels
                    }
                );
            }
            
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        //Id = 1,
                        Name = "Edelbrock 2701 Chevrolet S/B",
                        Price = 144.20m,
                        Description = "Performance Intake Manifold",
                        ImageSource = "",
                        PurchaseURL = "http://www.jegs.com/i/Edelbrock/350/2701/10002/-1",
                        // HP+ = 5
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Edelbrock Pro-Flo XT Chevrolet S/B",
                        Price = 376.00m,
                        Description = "High Performance Intake Manifold",
                        ImageSource = "",
                        PurchaseURL = "https://store.edelbrock.com/collections/intake-manifolds/products/pro-flo-xt-vortec-for-chevrolet",
                        // HP+ = 30
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Edelbrock Pro-Flo XT for LS",
                        Price = 624.75m,
                        Description = "High Performance Intake Manifold",
                        ImageSource = "",
                        PurchaseURL = "http://performanceparts.com/part/Edelbrock/71403",
                        // HP+ = 30
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Edelbrock Pro-Flo XT for Chevrolet L/B",
                        Price = 592.84m,
                        Description = "High Performance Intake Manifold",
                        ImageSource = "",
                        PurchaseURL = "http://performanceparts.com/part/Edelbrock/71363",
                        // HP+ = 25
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Edelbrock 2161 Chevrolet L/B",
                        Price = 262.72m,
                        Description = "Performance Intake Manifold",
                        ImageSource = "",
                        PurchaseURL = "http://performanceparts.com/part/Edelbrock/2161",
                        // HP+ = 5
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 478.99m,
                        Description = "Air Intake for Chevrolet Corvette 6.2 PN# 63-3073",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3073",
                        // HP+ = 17.2
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 302.99m,
                        Description = "Air Intake for Chevrolet Camaro 6.2 PN# 63-3074",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3074",
                        // HP+ = 18.62
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 302.99m,
                        Description = "Air Intake for Chevrolet Camaro 3.6 PN# 63-4523TP",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4523TP",
                        // HP+ = 15.63
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 272.99m,
                        Description = "Air Intake for Chevrolet Impala 3.6 PN# 69-4526TS",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4526TS",
                        // HP+ = 11.73
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 272.99m,
                        Description = "Air Intake for Chevrolet Impala 3.6 PN# 69-4526TS",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4526TS",
                        // HP+ = 11.73
                    },
                new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake",
                    Price = 199.99m,
                    Description = "Air Intake for Chevrolet Malibu 2.0 PN# 63-3091",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3091",
                    // HP+ = 14.21
                },
                new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake",
                    Price = 302.99m,
                    Description = "Air Intake for Chevrolet Malibu 2.5 PN# 69-4529TS",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4529TS",
                    // HP+ = 8.24
                },
                new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake",
                    Price = 372.99m,
                    Description = "Air Intake for Ford Mustang 3.7 PN# 69-3529TP",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-3529TP",
                    // HP+ = 11.79
                },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 373.99m,
                        Description = "Air Intake for Ford Mustang 5.0 PN# 63-2578",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-2578",
                        // HP+ = 20.27
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 305.99m,
                        Description = "Air Intake for Ford Mustang GT500 5.8 PN# 57-2579",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=57-2579",
                        // HP+ = 11.79
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 272.99m,
                        Description = "Air Intake for Dodge 3.6 PN# 63-1564",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-1564",
                        // HP+ = 8.09
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 264.99m,
                        Description = "Air Intake for Dodge 5.7 & 6.1 PN# 57-1542",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=57-1542",
                        // HP+ = 31.42
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 272.99m,
                        Description = "Air Intake for Dodge 6.4 PN# 69-2545TP",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-2545TP",
                        // HP+ = 22.24
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "K&N Air Intake",
                        Price = 280.99m,
                        Description = "Air Intake for Dodge 6.2 PN# 69-2550TTK",
                        ImageSource = "",
                        PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-2550TTK",
                        // HP+ = 38.95
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Flowmaster Exhaust Headers",
                        Price = 649.00m,
                        Description = "Exhaust Header for Chevrolet 350 small block V8 PN#814110",
                        ImageSource = "",
                        PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814110",
                        // HP+ = 15
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Flowmaster Exhaust Headers",
                        Price = 649.00m,
                        Description = "Exhaust Header for Chevrolet long block V8 PN#814111",
                        ImageSource = "",
                        PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814111",
                        // HP+ = 15
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Flowmaster Exhaust Headers",
                        Price = 315.00m,
                        Description = "Exhaust Header for Chevrolet 3.6 V6 PN#814122",
                        ImageSource = "",
                        PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814122",
                        // HP+ = 5
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Flowmaster Exhaust Headers",
                        Price = 315.00m,
                        Description = "Exhaust Header for Ford 4.6 V8 PN#814212",
                        ImageSource = "",
                        PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814212",
                        // HP+ = 15
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra XP Carb 600 CFM",
                        Price = 649.00m,
                        Description = "Holley Performance Carburetor Ultra XP 600 CFM PN#0-80801RDX",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                        // HP+ = 37
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra XP Carb 650 CFM",
                        Price = 656.06m,
                        Description = "Holley Performance Carburetor Ultra XP 650 CFM PN#0-80802RDX",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                        // HP+ = 37
                    }, new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra XP Carb 750 CFM",
                        Price = 683.06m,
                        Description = "Holley Performance Carburetor Ultra XP 850 CFM PN#0-80803RDX",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                        // HP+ = 37
                    }, new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra XP Carb 850 CFM",
                        Price = 710.96m,
                        Description = "Holley Performance Carburetor Ultra XP 850 CFM PN#0-80804RDX",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                        // HP+ = 37
                    }, new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra XP Carb 950 CFM",
                        Price = 738.86m,
                        Description = "Holley Performance Carburetor Ultra XP 950 CFM PN#0-80805RDX",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                        // HP+ = 37
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra Avenger Carb 670 CFM",
                        Price = 489.56m,
                        Description = "Holley Performance Carburetor Ultra Avenger 670 CFM PN#0-86670BL",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                        // HP+ = 17
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra Avenger Carb 770 CFM",
                        Price = 489.56m,
                        Description = "Holley Performance Carburetor Ultra Avenger 770 CFM PN#0-86770BL",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                        // HP+ = 17
                    },
                    new Product
                    {
                        //Id = 1,
                        Name = "Holley Ultra Avenger Carb 870 CFM",
                        Price = 489.56m,
                        Description = "Holley Performance Carburetor Ultra Avenger 870 CFM PN#0-86870BL",
                        ImageSource = "",
                        PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                        // HP+ = 17
                    });
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
