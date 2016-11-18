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
                                         Name = "2dr Covertible"
                                     }
                                         }
                                    }, new Year
                                    {
                                        Years = 1954,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1955,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (235ci 6cyl)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (265ci 8cyl)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1956,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (235ci 6cyl)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (265ci 8cyl)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1957,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1958,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1959,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1960,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1961,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Covertible (283ci 8cyl 4M)"
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl 3M)"
                                            }
                                        }
                                    }, new Year
                                    {
                                        Years = 1962
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
                        Name = "Dodge",
                        Models = DodgeModels
                    },
                    new Make
                    {
                        Name = "Pontiac",
                        Models = PontiacModels
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

            if (!context.Engines.Any())
            {
                context.Engines.AddRange(
                    //var ChevyEngines
                    new Engine
                    {
                        //Id = 1,//Chevy
                        Cylinders = 6,
                        Volume = 235,
                        HorsePower = 150,
                        Induction = Induction.Carbureted,
                        Intake = Intake.NaturallyAspirated
                    },
                    new Engine
                    {
                        //Id = 1,
                        Cylinders = 6,
                        Volume = 230,
                        HorsePower = 150,
                        Induction = Induction.Carbureted,
                        Intake = Intake.NaturallyAspirated
                    },
                    new Engine
                    {
                        //Id = 1,
                        Cylinders = 6,
                        Volume = 250,
                        HorsePower = 150,
                        Induction = Induction.Carbureted,
                        Intake = Intake.NaturallyAspirated
                    },
                     new Engine
                     {
                         //Id = 1,
                         Cylinders = 8,
                         Volume = 265,
                         HorsePower = 180,
                         Induction = Induction.Carbureted,
                         Intake = Intake.NaturallyAspirated
                     },
                      new Engine
                      {
                          //Id = 1,
                          Cylinders = 8,
                          Volume = 283,
                          HorsePower = 255,
                          Induction = Induction.Carbureted,
                          Intake = Intake.NaturallyAspirated
                      },
                       new Engine
                       {
                           //Id = 1,
                           Cylinders = 8,
                           Volume = 302,
                           HorsePower = 290,
                           Induction = Induction.Carbureted,
                           Intake = Intake.NaturallyAspirated
                       },
                       new Engine
                       {
                           //Id = 1,
                           Cylinders = 8,
                           Volume = 305,
                           HorsePower = 190,
                           Induction = Induction.Carbureted,
                           Intake = Intake.NaturallyAspirated
                       },
                       new Engine
                       {
                           //Id = 1,
                           Cylinders = 8,
                           Volume = 307,
                           HorsePower = 180,
                           Induction = Induction.Carbureted,
                           Intake = Intake.NaturallyAspirated
                       },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 327,
                            HorsePower = 305,
                            Induction = Induction.Carbureted,
                            Intake = Intake.NaturallyAspirated
                        },
                         new Engine
                         {
                             //Id = 1,
                             Cylinders = 8,
                             Volume = 350,
                             HorsePower = 270,
                             Induction = Induction.Carbureted,
                             Intake = Intake.NaturallyAspirated
                         },
                    new Engine
                    {
                        //Id = 1,
                        Cylinders = 8,
                        Volume = 396,
                        HorsePower = 355,
                        Induction = Induction.Carbureted,
                        Intake = Intake.NaturallyAspirated
                    },

                    new Engine
                    {
                        //Id = 2,
                        Cylinders = 8,
                        Volume = 427,
                        HorsePower = 390,
                        Induction = Induction.Carbureted,
                        Intake = Intake.NaturallyAspirated
                    },
                     new Engine
                     {
                         //Id = 1,
                         Cylinders = 8,
                         Volume = 454,
                         HorsePower = 390,
                         Induction = Induction.Carbureted,
                         Intake = Intake.NaturallyAspirated
                     },
                      new Engine
                      {
                          //Id = 1,
                          Cylinders = 8,
                          Volume = 350,
                          HorsePower = 300,
                          Induction = Induction.EFI,
                          Intake = Intake.NaturallyAspirated
                      },
                      new Engine
                      {
                          //Id = 1,
                          Cylinders = 8,
                          Volume = 366,
                          HorsePower = 380,
                          Induction = Induction.EFI,
                          Intake = Intake.NaturallyAspirated
                      },
                      new Engine
                      {
                          //Id = 2,
                          Cylinders = 8,
                          Volume = 427,
                          HorsePower = 505,
                          Induction = Induction.EFI,
                          Intake = Intake.NaturallyAspirated
                      },
                       new Engine
                       {
                           //Id = 1,
                           Cylinders = 8,
                           Volume = 383,
                           HorsePower = 420,
                           Induction = Induction.EFI,
                           Intake = Intake.NaturallyAspirated
                       },
                        new Engine
                        {//Chevy
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        //Amc
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        },
                        new Engine
                        {
                            //Id = 1,
                            Cylinders = 8,
                            Volume = 383,
                            HorsePower = 640,
                            Induction = Induction.EFI,
                            Intake = Intake.SuperCharged
                        }


                    );
                context.SaveChanges();

            }

            if (!context.Cars.Any())
            {
                // Honda cars
                var hondas = new List<Car>()
                {
                    new Car
                    {
                        Make = "Honda",
                        Model = "Accord",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.FrontWD,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()

                    },
                    new Car
                    {
                        Make = "Honda",
                        Model = "Civic",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.FrontWD,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }
                };

                //var hondaEngines =  

                //foreach (var honda in hondas)
                //{
                //    honda.CompatibleEngines = myEngines;
                //}


                context.Cars.AddRange(
                    new Car
                    {
                        //Id = 1,
                        Make = "Honda",
                        Model = "Accord",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.FrontWD,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()

                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Honda",
                        Model = "Civic",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.FrontWD,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },

                    new Car
                    {
                        //Id = 1,
                        Make = "BMW",
                        Model = "X1",
                        Year = 2016,
                        Doors = 4,
                        Drive = Drive.AllWD,
                        Transmission = Transmission.Automatic,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    //started input of sample data (DG)
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Monte Carlo",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1953,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1954,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1955,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1956,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1957,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1958,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1959,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1960,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1961,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1962,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1963,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2003,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2004,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2005,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2006,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2007,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2008,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2009,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2010,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2011,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2012,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2013,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2014,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2015,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2016,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Corvette",
                        Year = 2017,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1966,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1967,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1968,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1969,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1970,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1971,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1972,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1973,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1974,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1975,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1976,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1977,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1978,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1979,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1980,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1981,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1982,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1983,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1984,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1985,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1986,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1987,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1988,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1989,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1990,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1991,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1992,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1993,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1994,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1995,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1996,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1997,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1998,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 1999,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2000,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2001,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2002,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },

                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2010,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2011,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2012,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2013,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2014,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2015,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2016,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Camaro",
                         Year = 2017,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1965,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1966,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1967,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1968,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1969,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1970,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1971,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1972,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1973,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1974,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1975,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1976,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1977,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1978,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1979,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1980,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1981,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1982,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1983,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1984,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1985,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1986,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1987,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1988,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1989,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1990,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1991,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1992,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1993,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1994,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1995,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1996,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1997,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1998,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 1999,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2000,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2001,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2002,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2003,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2004,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2005,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Caprice",
                         Year = 2006,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                     new Car
                     {
                         //Id = 1,
                         Make = "Chevy",
                         Model = "Malibu",
                         Year = 1964,
                         Doors = 2,
                         Drive = Drive.RearWD,
                         Transmission = Transmission.Manual,
                         Fuel = Fuel.Gasoline,
                         CompatibleEngines = context.EngineInstalls.ToList()
                     },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2003,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2004,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2005,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2006,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2007,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2008,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2009,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2010,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2011,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2012,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2013,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2014,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2015,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2016,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Malibu",
                        Year = 2017,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1957,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1958,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1959,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1960,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1961,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1962,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1963,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2003,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2004,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2005,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2006,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2007,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2008,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2009,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2010,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2011,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2012,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2013,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2014,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2015,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2016,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Impala",
                        Year = 2017,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2003,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2004,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2005,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2006,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2007,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2008,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2009,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2010,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2011,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2012,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2013,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2014,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2015,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2016,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Mustang",
                        Year = 2017,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Challenger",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Dodge",
                        Model = "Charger",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1957,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1957,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1958,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1959,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1960,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1961,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1962,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1963,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Ford",
                        Model = "Ranchero",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Firebird",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "GTO",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1981,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1982,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1983,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1984,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1985,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1986,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1987,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1988,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1989,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1990,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1991,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1992,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1993,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1994,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1995,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1996,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1997,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1998,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 1999,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 2000,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 2001,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Pontiac",
                        Model = "Trans Am",
                        Year = 2002,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "AMX",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "AMC",
                        Model = "Javelin",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Barracuda",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Road Runner",
                        Year = 1980,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Duster",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "SuperBird",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "GTX",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "GTX",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "GTX",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "GTX",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "GTX",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1956,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1957,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1958,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1959,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1960,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1961,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1962,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1963,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Plymouth",
                        Model = "Fury",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Mercury",
                        Model = "Cougar",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1978,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Nova",
                        Year = 1979,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    },
                    new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1964,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1965,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1966,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1967,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1968,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1969,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1970,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1971,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1972,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1973,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1974,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1975,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1976,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
                    }, new Car
                    {
                        //Id = 1,
                        Make = "Chevy",
                        Model = "Chevelle",
                        Year = 1977,
                        Doors = 2,
                        Drive = Drive.RearWD,
                        Transmission = Transmission.Manual,
                        Fuel = Fuel.Gasoline,
                        CompatibleEngines = context.EngineInstalls.ToList()
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
