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
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 250
                                            },

                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (400ci 8cyl)",
                                                 Horsepower = 265
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (402ci 8cyl)",
                                                 Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe SS 454 (454ci 8cyl)",
                                                 Horsepower = 360
                                            },
                                        }
                                    },
                                    new Year
                                    {
                                        Years = 1971,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 245
                                            },

                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 270
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (402ci 8cyl)",
                                                 Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe SS 454 (454ci 8cyl)",
                                                 Horsepower = 365
                                            },
                                        }
                                    },
                                    new Year
                                    {
                                        Years = 1972,
                                         Styles = new List<Style>()
                                        {
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 175
                                            },

                                            new Style
                                            {
                                                Name = "2dr Coupe (402ci 8cyl)",
                                                 Horsepower = 240
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (454ci 8cyl)",
                                                 Horsepower = 270
                                            }
                                         },
                                    },
                                    new Year
                                    {
                                        Years = 1973,
                                         Styles = new List<Style>()
                                        {
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 145
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 175
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (454ci 8cyl)",
                                                 Horsepower = 245
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe Landue (350ci 8cyl)",
                                                 Horsepower = 145
                                            }
                                         },
                                    },
                                    new Year
                                    {
                                        Years = 1974,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 160
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (400ci 8cyl)",
                                                 Horsepower = 150
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (400ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name = "2dr Coupe (454ci 8cyl)",
                                                 Horsepower = 235
                                            },
                                         },
                                    },
                                    new Year
                                    {
                                        Years = 1975,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 145
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 155
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (400ci 8cyl)",
                                                 Horsepower = 175
                                            },
                                               new Style
                                            {
                                                Name = "2dr Coupe (454ci 8cyl)",
                                                 Horsepower = 215
                                            },
                                         },
                                    },
                                    new Year
                                    {
                                        Years = 1976,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 140
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 145
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (400ci 8cyl)",
                                                 Horsepower = 175
                                            },
                                               new Style
                                            {
                                                Name = "2dr Coupe (454ci 8cyl)",
                                                 Horsepower = 215
                                            },
                                         },
                                    },
                                    new Year
                                    {
                                        Years = 1977,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 140
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (350ci 8cyl)",
                                                 Horsepower = 170
                                            },

                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1978,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 145
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 135
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1979,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (200ci 6cyl)",
                                                 Horsepower = 95
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 125
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 140
                                            },
                                                 new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 160
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1980,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (200ci 6cyl)",
                                                 Horsepower = 95
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe Turbo (231ci 6cyl)",
                                                 Horsepower = 170
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 155
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1981,
                                          Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (229ci 6cyl)",
                                                 Horsepower = 115
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe Turbo (231ci 6cyl)",
                                                 Horsepower = 170
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 155
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1982,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (229ci 6cyl)",
                                                 Horsepower = 115
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                               new Style
                                            {
                                                Name = "2dr Coupe (260ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe (305ci 8cyl)",
                                                 Horsepower = 155
                                            },
                                                 new Style
                                            {
                                                Name = "2dr Coupe Diesel (260ci 6cyl)",
                                                 Horsepower = 85
                                            },
                                                  new Style
                                            {
                                                Name = "2dr Coupe Diesel (350ci 8cyl)",
                                                 Horsepower = 120
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1983,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (229ci 6cyl)",
                                                 Horsepower = 115
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                               new Style
                                            {
                                                Name = "2dr Coupe (260ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 175
                                            },
                                                 new Style
                                            {
                                                Name = "2dr Coupe Diesel (260ci 6cyl)",
                                                 Horsepower = 85
                                            },
                                                  new Style
                                            {
                                                Name = "2dr Coupe Diesel (350ci 8cyl)",
                                                 Horsepower = 120
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1984,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (229ci 6cyl)",
                                                 Horsepower = 115
                                            },
                                             new Style
                                            {
                                                Name = "2dr Coupe (231ci 6cyl)",
                                                 Horsepower = 105
                                            },
                                               new Style
                                            {
                                                Name = "2dr Coupe (260ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                              new Style
                                            {
                                                Name = "2dr Coupe (267ci 8cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                                 new Style
                                            {
                                                Name = "2dr Coupe Diesel (260ci 6cyl)",
                                                 Horsepower = 85
                                            },
                                                  new Style
                                            {
                                                Name = "2dr Coupe Diesel (350ci 8cyl)",
                                                 Horsepower = 120
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1985,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (262ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1986,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (262ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1987,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (262ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                         }
                                    },
                                    new Year
                                    {
                                        Years = 1988,
                                         Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name = "2dr Coupe (262ci 6cyl)",
                                                 Horsepower = 130
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe  (305ci 8cyl)",
                                                 Horsepower = 165
                                            },
                                                new Style
                                            {
                                                Name = "2dr Coupe SS (305ci 8cyl)",
                                                 Horsepower = 180
                                            },
                                         }
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
                                                Name = "2dr Covertible(235ci 6cyl)",
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
                                                Name = "2dr Covertible(235ci 6cyl)",
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
                                                Name = "2dr Convertible (235ci 6cyl)",
                                                Horsepower = 155
                                            },
                                            new Style
                                            {
                                                Name ="2dr Convertible (265ci 8cyl)",
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
                                                Name = "2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                            new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 220
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 250
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 250
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 230
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 275
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                                                Name ="2dr Covertible (327ci 8cyl)",
                                                Horsepower = 250
                                            },
                                             new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 245
                                            },
                                              new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 270
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
                                                Horsepower = 275
                                            },
                                               new Style
                                            {
                                                Name ="2dr Covertible (283ci 8cyl)",
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
                    }, new Make
                    {
                        Name = "Dodge",
                        Models = DodgeModels
                    },
                    new Make
                    {
                        Name = "Dodge",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                  Name = "Challenger",
                                Years = new List<Year>()
                                {
                                   new Year
                                   {
                                       Years = 1970,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Coupe (318ci 8cyl)",
                                         Horsepower = 230
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (340ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (383ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (383ci 8cyl)",
                                         Horsepower = 335
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (318ci 8cyl)",
                                         Horsepower = 230
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (340ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (383ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (383ci 8cyl)",
                                         Horsepower = 335
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe R/T (426ci 8cyl)",
                                         Horsepower = 425
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe R/T (440ci 8cyl)",
                                         Horsepower = 390
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (426ci 8cyl)",
                                         Horsepower = 425
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe T/A (340ci 8cyl)",
                                         Horsepower = 290
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1971,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Coupe (318ci 8cyl)",
                                         Horsepower = 230
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (340ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (383ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (383ci 8cyl)",
                                         Horsepower = 300
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (318ci 8cyl)",
                                         Horsepower = 230
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (340ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (383ci 8cyl)",
                                         Horsepower = 275
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (383ci 8cyl)",
                                         Horsepower = 300
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe R/T (426ci 8cyl)",
                                         Horsepower = 425
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe R/T (440ci 8cyl)",
                                         Horsepower = 385
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1972,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Coupe (318ci 8cyl)",
                                         Horsepower = 150
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1973,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Coupe (318ci 8cyl)",
                                         Horsepower = 150
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (340ci 8cyl)",
                                         Horsepower = 240
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1974,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Coupe (318ci 8cyl)",
                                         Horsepower = 150
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (360ci 8cyl)",
                                         Horsepower = 245
                                        },
                                       },
                                   },
                                },
                            },
                        },
                    },
                    new Make
                    {
                        Name = "AMC",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "AMX",
                                Years = new List<Year>()
                                {
                                   new Year
                                   {
                                       Years = 1968,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (290ci 8cyl)",
                                         Horsepower = 225
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (343ci 8cyl)",
                                         Horsepower = 280
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (390ci 8cyl)",
                                         Horsepower = 315
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1969,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (290ci 8cyl)",
                                         Horsepower = 225
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (343ci 8cyl)",
                                         Horsepower = 280
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (390ci 8cyl)",
                                         Horsepower = 315
                                        },
                                        new Style
                                        {
                                         Name = "2dr SS Fastback (390ci 8cyl)",
                                         Horsepower = 340
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1970,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (390ci 8cyl)",
                                         Horsepower = 325
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1979,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Liftback (258ci 6cyl)",
                                         Horsepower = 110
                                        },
                                       },
                                   },
                                   new Year
                                   {
                                       Years = 1980,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Liftback (258ci 6cyl)",
                                         Horsepower = 110
                                        },
                                       },
                                   },
                                },
                            },
                             new Model
                            {
                                Name = "Javelin",
                                Years = new List<Year>()
                                {
                                    new Year
                                   {
                                       Years = 1968,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (343ci 8cyl)",
                                         Horsepower = 280
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1969,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (343ci 8cyl)",
                                         Horsepower = 280
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (390ci 8cyl)",
                                         Horsepower = 315
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1970,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 245
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (390ci 8cyl)",
                                         Horsepower = 325
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1971,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 285
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (401ci 8cyl)",
                                         Horsepower = 330
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1972,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 195
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 220
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (401ci 8cyl)",
                                         Horsepower = 255
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1973,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 195
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 220
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (401ci 8cyl)",
                                         Horsepower = 255
                                        },
                                       },
                                   },
                                    new Year
                                   {
                                       Years = 1974,
                                       Styles = new List<Style>()
                                       {
                                        new Style
                                        {
                                         Name = "2dr Fastback (360ci 8cyl)",
                                         Horsepower = 220
                                        },
                                        new Style
                                        {
                                         Name = "2dr Fastback (401ci 8cyl)",
                                         Horsepower = 235
                                        },
                                       },
                                   },
                                },
                             },
                        },
                    },
                    new Make
                    {
                        Name = "Plymouth",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "Barracuda",
                                Years = new List<Year>()
                                {
                                    
                                    new Year
                                    {
                                        Years = 1964,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (170ci 6cyl)",
                                                Horsepower = 101
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 180
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1965,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 235
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1966,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 235
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1967,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (273ci 8cyl)",
                                                Horsepower = 235
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (273ci 8cyl)",
                                                Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (273ci 8cyl)",
                                                Horsepower = 235
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 280
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 280
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1968,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (340ci 8cyl)",
                                                Horsepower = 275
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (340ci 8cyl)",
                                                Horsepower = 275
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 300
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1969,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (340ci 8cyl)",
                                                Horsepower = 275
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (340ci 8cyl)",
                                                Horsepower = 275
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1972,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1973,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        }// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1974,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 290
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 330
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        }// new List<Style>
                                    }// new Year
                                }// new List<Year>
                            },// new Model
                            new Model
                            {
                                Name = "Duster",
                                Years = new List<Year>()
                                {
                                    new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (198ci 6cyl)",
                                                Horsepower = 125
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1972,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (198ci 6cyl)",
                                                Horsepower = 125
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1973,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (198ci 6cyl)",
                                                Horsepower = 125
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1974,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (198ci 6cyl)",
                                                Horsepower = 125
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1975,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (198ci 6cyl)",
                                                Horsepower = 125
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (225ci 6cyl)",
                                                Horsepower = 145
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 230
                                            },
                                        },// new List<Style>
                                    },// new Year
                                }// new List<Year>
                            },// new Model
                            new Model
                            {
                                Name = "Superbird",
                                Years = new List<Year>()
                                {
                                    new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                        },// new List<Style>
                                    },// new Year
                                }// new List<Year>
                            },// new Model
                            new Model
                            {
                                Name = "Road Runner",
                                Years = new List<Year>()
                                {
                                    new Year
                                    {
                                        Years = 1968,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 335
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1969,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 335
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 350
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 335
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 350
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 335
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (383ci 8cyl)",
                                                Horsepower = 335
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (383ci 8cyl)",
                                                Horsepower = 300
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 385
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1972,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (340ci 8cyl)",
                                                Horsepower = 240
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 255
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 280
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 330
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1973,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (340ci 8cyl)",
                                                Horsepower = 240
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 260
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 280
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 170
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1974,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (360ci 8cyl)",
                                                Horsepower = 245
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 250
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 275
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 170
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 175
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1975,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (360ci 8cyl)",
                                                Horsepower = 180
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (360ci 8cyl)",
                                                Horsepower = 190
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 190
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (318ci 8cyl)",
                                                Horsepower = 150
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (400ci 8cyl)",
                                                Horsepower = 235
                                            },
                                        },// new List<Style>
                                    },// new Year
                                }// new List<Year>
                            },// new Model
                            new Model
                            {
                                Name = "GTX",
                                Years = new List<Year>()
                                {
                                    new Year
                                    {
                                        Years = 1967,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1968,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1969,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 350
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 350
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 375
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 390
                                            },
                                        },// new List<Style>
                                    },// new Year
                                    new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                            {
                                                Name =  "2dr Coupe (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 370
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 370
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (426ci 8cyl)",
                                                Horsepower = 425
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Coupe (440ci 8cyl)",
                                                Horsepower = 385
                                            },
                                            new Style
                                            {
                                                Name =  "2dr Convertible (440ci 8cyl)",
                                                Horsepower = 385
                                            },
                                        },// new List<Style>
                                    },// new Year
                                }// new List<Year>
                            },// new Model
                        }// new List<Model>
                    },// new Make
                    new Make
                    {
                        Name = "Mercury",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "Cougar",
                                Years = new List<Year>()
                                {
                                     new Year
                                    {
                                        Years = 1967,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (289ci 8cyl)",
                                         Horsepower = 200
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (289ci 8cyl)",
                                         Horsepower = 225
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT Coupe (390ci 8cyl)",
                                         Horsepower = 320
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1968,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (302ci 8cyl)",
                                         Horsepower = 230
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (390ci 8cyl)",
                                         Horsepower = 265
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (390ci 8cyl)",
                                         Horsepower = 280
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (390ci 8cyl)",
                                         Horsepower = 325
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT-E Coupe (428ci 8cyl)",
                                         Horsepower = 335
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT-E Coupe (427ci 8cyl)",
                                         Horsepower = 390
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1969,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 250
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (390ci 8cyl)",
                                         Horsepower = 320
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (429ci 8cyl)",
                                         Horsepower = 360
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 290
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT-E Coupe (390ci 8cyl)",
                                         Horsepower = 320
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT-E Coupe (429ci 8cyl)",
                                         Horsepower = 360
                                        },
                                        new Style
                                        {
                                         Name = "2dr Eliminator Coupe (428ci 8cyl)",
                                         Horsepower = 335
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 250
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 300
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (428ci 8cyl)",
                                         Horsepower = 335
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 250
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 300
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (428ci 8cyl)",
                                         Horsepower = 335
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 250
                                        },
                                        new Style
                                        {
                                         Name = "2dr Eliminator Coupe (428ci 8cyl)",
                                         Horsepower = 335
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 285
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 285
                                        },
                                        new Style
                                        {
                                         Name = "2dr GT Coupe (429ci 8cyl)",
                                         Horsepower = 370
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1972,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 164
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 262
                                        },
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 266
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 164
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 262
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 266
                                        },
                                     },
                                    },
                                     new Year
                                    {
                                        Years = 1973,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Coupe (351ci 8cyl)",
                                         Horsepower = 264
                                        },
                                        new Style
                                        {
                                         Name = "2dr Convertible (351ci 8cyl)",
                                         Horsepower = 264
                                        },
                                     },
                                    },
                                },
                            },
                        },
                    },
                    new Make
                    {
                        Name = "Oldsmobile",
                        Models = new List<Model>()
                        {
                            new Model
                            {
                                Name = "4-4-2",
                                Years = new List<Year>()
                                {
                                     new Year
                                    {
                                        Years = 1968,
                                        Styles = new List<Style>(){
                                        new Style
                                        {
                                         Name = "2dr Covertible (400ci 8cyl 4m)",
                                         Horsepower = 290
                                     },
                                        new Style
                                        {
                                         Name = "2dr Covertible (400ci 8cyl 4a)",
                                         Horsepower = 290
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (400ci 8cyl 4m)",
                                         Horsepower = 350
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (400ci 8cyl 4a)",
                                         Horsepower = 325
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (400ci 8cyl 4m)",
                                         Horsepower = 350
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (400ci 8cyl 4a)",
                                         Horsepower = 325
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe W-30 (400ci 8cyl 4m)",
                                         Horsepower = 360
                                     },
                                        new Style
                                        {
                                         Name = "2dr Convertible W-30 (400ci 8cyl 4m)",
                                         Horsepower = 360
                                     },
                                        new Style
                                        {
                                         Name = "2dr Coupe Hurst (455ci 8cyl 4m)",
                                         Horsepower = 390
                                     },
                                         }
                                    }, new Year
                                    {
                                        Years = 1969,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                        {
                                         Name = "2dr Covertible (400ci 8cyl 4m)",
                                         Horsepower = 290
                                     },
                                        new Style
                                        {
                                         Name = "2dr Covertible (400ci 8cyl 4a)",
                                         Horsepower = 290
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (400ci 8cyl 4m)",
                                         Horsepower = 350
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (400ci 8cyl 4a)",
                                         Horsepower = 325
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (400ci 8cyl 4m)",
                                         Horsepower = 350
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (400ci 8cyl 4a)",
                                         Horsepower = 325
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe Hurst (455ci 8cyl 4m)",
                                         Horsepower = 380
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe W-30 (400ci 8cyl 4m)",
                                         Horsepower = 360
                                     },
                                        new Style
                                        {
                                         Name = "2dr Convertible W-30 (400ci 8cyl 4m)",
                                         Horsepower = 360
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe W-31 (350ci 8cyl 4a)",
                                         Horsepower = 325
                                     },
                                        }
                                    },
                                     new Year
                                    {
                                        Years = 1970,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                        {
                                         Name = "2dr Covertible (455ci 8cyl 4m)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Covertible (455ci 8cyl 4a)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (455ci 8cyl 4m)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe (455ci 8cyl 4a)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (455ci 8cyl 4m)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Sport Coupe (455ci 8cyl 4a)",
                                         Horsepower = 365
                                     },
                                        new Style
                                        {
                                         Name = "2dr Holiday Coupe W-30 (455ci 8cyl 4m)",
                                         Horsepower = 370
                                     },
                                        new Style
                                        {
                                         Name = "2dr Convertible W-30 (455ci 8cyl 4m)",
                                         Horsepower = 370
                                     },
                                        }
                                    },
                               new Year
                                    {
                                        Years = 1971,
                                        Styles = new List<Style>()
                                        {
                                            new Style
                                        {
                                         Name = "2dr Covertible (455ci 8cyl 4m)",
                                         Horsepower = 340
                                     },
                                        new Style
                                        {
                                         Name = "2dr Covertible (455ci 8cyl 4a)",
                                         Horsepower = 340
                                        },
                                        new Style
                                        {
                                            Name = "2dr Hardtop Coupe (455ci 8cyl 4m)",
                                            Horsepower = 340
                                        },
                                        new Style
                                        {
                                            Name = "2dr Hardtop Coupe (455ci 8cyl 4a)",
                                            Horsepower = 340
                                        },
                                        new Style
                                        {
                                            Name = "2dr Coupe W-30 (455ci 8cyl 4m)",
                                            Horsepower = 350
                                        },
                                        new Style
                                        {
                                            Name = "2dr Convertible W-30 (455ci 8cyl 4m)",
                                            Horsepower = 350
                                        },
                                    },
                                },
                            },
                        },
                    }
                });

                var test = new Product { };
                var style = new Style { };

                var carMod = new CarMod
                {
                    Style = style,
                    Product = test
                };

            }
            if (!context.Products.Any())
            {
                var Edelbrock2701 = new Product
                {
                    Name = "Edelbrock 2701 Chevy S/B",
                    Price = 144.20m,
                    Description = "Performance Intake Manifold",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Edelbrock 2701.jpg",
                    PurchaseURL = "http://www.jegs.com/i/Edelbrock/350/2701/10002/-1",
                    // HP+ = 5
                };
                var EdelbrockProFloXTChevySB = new Product
                {
                    Name = "Edelbrock Pro-Flo XT Chevy S/B",
                    Price = 376.00m,
                    Description = "High Performance Intake Manifold",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Edelbrock Pro-Flo XT.jpg",
                    PurchaseURL = "https://store.edelbrock.com/collections/intake-manifolds/products/pro-flo-xt-vortec-for-chevrolet",
                    // HP+ = 30 
                };
                var EdelbrockProFloXTforLS = new Product
                {
                    //Id = 1,
                    Name = "Edelbrock Pro-Flo XT for LS",
                    Price = 624.75m,
                    Description = "High Performance Intake Manifold",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Edelbrock Pro-Flo XT LS.jpg",
                    PurchaseURL = "http://performanceparts.com/part/Edelbrock/71403",
                    // HP+ = 30
                };
                var EdelbrockProFloXTforChevyLB = new Product
                {
                    //Id = 1,
                    Name = "Edelbrock Pro-Flo XT for Chevrolet L/B",
                    Price = 592.84m,
                    Description = "High Performance Intake Manifold",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Edelbrock Pro-Flo XT Chevy Long Block.jpg",
                    PurchaseURL = "http://performanceparts.com/part/Edelbrock/71363",
                    // HP+ = 25
                };
                var Edelbrock2161ChevyLB = new Product
                {
                    //Id = 1,
                    Name = "Edelbrock 2161 Chevrolet L/B",
                    Price = 262.72m,
                    Description = "Performance Intake Manifold",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Edelbrock 2161 LongBlock.jpg",
                    PurchaseURL = "http://performanceparts.com/part/Edelbrock/2161",
                    // HP+ = 5
                };
                var KNAirIntakeCorvette62 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Corvette 6.2",
                    Price = 478.99m,
                    Description = "Air Intake for Chevrolet Corvette 6.2 PN# 63-3073",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3073",
                    // HP+ = 17.2
                };
                var KNAirIntakeCamaro62 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Camaro 6.2",
                    Price = 302.99m,
                    Description = "Air Intake for Chevrolet Camaro 6.2 PN# 63-3074",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3074",
                    // HP+ = 18.62
                };
                var KNAirIntakeCamaro36 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Camaro 3.6",
                    Price = 302.99m,
                    Description = "Air Intake for Chevrolet Camaro 3.6 PN# 63-4523TP",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4523TP",
                    // HP+ = 15.63
                };
                var KNAirIntakeImpala36 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Impala 3.6",
                    Price = 272.99m,
                    Description = "Air Intake for Chevrolet Impala 3.6 PN# 69-4526TS",
                    ImageSource = "",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4526TS",
                    // HP+ = 11.73
                };
                var KNAirIntakeMalibu20 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Malibu 2.0",
                    Price = 199.99m,
                    Description = "Air Intake for Chevy Malibu 2.0 PN# 63-3091",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Chevy 2.0 Malibu PN#63-3091.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-3091",
                    // HP+ = 14.21
                };
                var KNAirIntakeMalibu25 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Malibu 2.5",
                    Price = 302.99m,
                    Description = "Air Intake for Chevy Malibu 2.5 PN# 69-4529TS",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Chevy 2.5 Malibu PN#69-4529TS.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-4529TS",
                    // HP+ = 8.24
                };
                var KNAirIntakeMustang37 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Mustang 3.7",
                    Price = 372.99m,
                    Description = "Air Intake for Ford Mustang 3.7 PN# 69-3529TP",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Ford 3.7 PN#69-3529TP.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-3529TP",
                    // HP+ = 11.79
                };
                var KNAirIntakeMustang50 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Mustang 5.0",
                    Price = 373.99m,
                    Description = "Air Intake for Ford Mustang 5.0 PN# 63-2578",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Ford 5.0 PN#63-2578.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-2578",
                    // HP+ = 20.27
                };
                var KNAirIntakeMustang58 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Mustang 5.8",
                    Price = 305.99m,
                    Description = "Air Intake for Ford Mustang GT500 5.8 PN# 57-2579",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Ford 5.8 PN#57-2579.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=57-2579",
                    // HP+ = 11.79
                };
                var KNAirIntakeDodge36 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Dodge 3.6",
                    Price = 272.99m,
                    Description = "Air Intake for Dodge 3.6 PN# 63-1564",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Dodge 3.6 PN#63-1564.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=63-1564",
                    // HP+ = 8.09
                };
                var KNAirIntakeDodge57or61 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Dodge 5.7 or 6.1",
                    Price = 264.99m,
                    Description = "Air Intake for Dodge 5.7 & 6.1 PN# 57-1542",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Dodge 5.7 & 6.1 PN#57-1542.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=57-1542",
                    // HP+ = 31.42
                };
                var KNAirIntakeDodge64 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Dodge 6.4",
                    Price = 272.99m,
                    Description = "Air Intake for Dodge 6.4 PN# 69-2545TP",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Dodge 6.4 PN#69-2545TP.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-2545TP",
                    // HP+ = 22.24
                };
                var KNAirIntakeDodge62 = new Product
                {
                    //Id = 1,
                    Name = "K&N Air Intake Dodge 6.2",
                    Price = 280.99m,
                    Description = "Air Intake for Dodge 6.2 PN# 69-2550TTK",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/K&N Dodge 6.2 PN#69-2550TTK.jpg",
                    PurchaseURL = "http://www.knfilters.com/search/product.aspx?prod=69-2550TTK",
                    // HP+ = 38.95
                };
                var FlowmasterExhaustHeadersChevy350 = new Product
                {
                    //Id = 1,
                    Name = "Flowmaster Exhaust Headers Chevy 350",
                    Price = 649.00m,
                    Description = "Exhaust Header for Chevrolet 350 small block V8 PN#814110",
                    ImageSource = "",
                    PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814110",
                    // HP+ = 15
                };
                var FlowmasterExhaustHeadersChevyLBV8 = new Product
                {
                    //Id = 1,
                    Name = "Flowmaster Exhaust Headers Chevy L/B V8",
                    Price = 649.00m,
                    Description = "Exhaust Header for Chevrolet long block V8 PN#814111",
                    ImageSource = "",
                    PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814111",
                    // HP+ = 15
                };
                var FlowmasterExhaustHeadersChevy36 = new Product
                {
                    //Id = 1,
                    Name = "Flowmaster Exhaust Headers Chevy 3.6",
                    Price = 315.00m,
                    Description = "Exhaust Header for Chevrolet 3.6 V6 PN#814122",
                    ImageSource = "",
                    PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814122",
                    // HP+ = 5
                };
                var FlowmasterExhaustHeadersFord46 = new Product
                {
                    //Id = 1,
                    Name = "Flowmaster Exhaust Headers Ford 4.6",
                    Price = 315.00m,
                    Description = "Exhaust Header for Ford 4.6 V8 PN#814212",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Flowmaster Exhaust Header Ford 4.6 V8 814212.jpg",
                    PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814212",
                    // HP+ = 15
                };
                var FlowmasterExhaustHeadersFord50 = new Product
                {
                    //Id = 1,
                    Name = "Flowmaster Exhaust Headers Ford 5.0",
                    Price = 315.00m,
                    Description = "Exhaust Header for Ford 5.0 V8 PN#814211",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Flowmaster Exhaust Header Carburated Ford 5.0 V8 814211.jpg",
                    PurchaseURL = "http://www.flowmastermufflers.com/keywords-search-results/?keywords=814211",
                    // HP+ = 15
                };
                var HolleyUltraXPCarb600CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra XP Carb 600 CFM",
                    Price = 649.00m,
                    Description = "Holley Performance Carburetor Ultra XP 600 CFM PN#0-80801RDX",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Ultra HP Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                    // HP+ = 37
                };
                var HolleyUltraXPCarb650CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra XP Carb 650 CFM",
                    Price = 656.06m,
                    Description = "Holley Performance Carburetor Ultra XP 650 CFM PN#0-80802RDX",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Ultra HP Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                    // HP+ = 37
                };
                var HolleyUltraXPCarb750CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra XP Carb 750 CFM",
                    Price = 683.06m,
                    Description = "Holley Performance Carburetor Ultra XP 850 CFM PN#0-80803RDX",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Ultra HP Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                    // HP+ = 37
                };
                var HolleyUltraXPCarb850CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra XP Carb 850 CFM",
                    Price = 710.96m,
                    Description = "Holley Performance Carburetor Ultra XP 850 CFM PN#0-80804RDX",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Ultra HP Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                    // HP+ = 37
                };
                var HolleyUltraXPCarb950CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra XP Carb 950 CFM",
                    Price = 738.86m,
                    Description = "Holley Performance Carburetor Ultra XP 950 CFM PN#0-80805RDX",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Ultra HP Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/ultra_xp/",
                    // HP+ = 37
                };
                var HolleyUltraAvengerCarb670CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra Avenger Carb 670 CFM",
                    Price = 489.56m,
                    Description = "Holley Performance Carburetor Ultra Avenger 670 CFM PN#0-86670BL",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Avenger Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                    // HP+ = 17
                };
                var HolleyUltraAvengerCarb770CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra Avenger Carb 770 CFM",
                    Price = 489.56m,
                    Description = "Holley Performance Carburetor Ultra Avenger 770 CFM PN#0-86770BL",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Avenger Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                    // HP+ = 17
                };
                var HolleyUltraAvengerCarb870CFM = new Product
                {
                    //Id = 1,
                    Name = "Holley Ultra Avenger Carb 870 CFM",
                    Price = 489.56m,
                    Description = "Holley Performance Carburetor Ultra Avenger 870 CFM PN#0-86870BL",
                    ImageSource = "C:/Users/Dad/Source/Repos/HorsePowerStore/src/HorsePowerStore/wwwroot/images/Holley Avenger Carb.jpg",
                    PurchaseURL = "https://holley.com/products/fuel_systems/carburetors/avenger/ultra_street_avenger/",
                    // HP+ = 17
                };

                context.Products.AddRange(
                    Edelbrock2701,
                    EdelbrockProFloXTChevySB,
                    EdelbrockProFloXTforLS,
                    EdelbrockProFloXTforChevyLB,
                    Edelbrock2161ChevyLB,
                    KNAirIntakeCorvette62,
                    KNAirIntakeCamaro62,
                    KNAirIntakeCamaro36,
                    KNAirIntakeImpala36,
                    KNAirIntakeMalibu20,
                    KNAirIntakeMalibu25,
                    KNAirIntakeMustang37,
                    KNAirIntakeMustang50,
                    KNAirIntakeMustang58,
                    KNAirIntakeDodge36,
                    KNAirIntakeDodge57or61,
                    KNAirIntakeDodge64,
                    KNAirIntakeDodge62,
                    FlowmasterExhaustHeadersChevy350,
                    FlowmasterExhaustHeadersChevyLBV8,
                    FlowmasterExhaustHeadersChevy36,
                    FlowmasterExhaustHeadersFord46,
                    FlowmasterExhaustHeadersFord50,
                    HolleyUltraXPCarb600CFM,
                    HolleyUltraXPCarb650CFM,
                    HolleyUltraXPCarb750CFM,
                    HolleyUltraXPCarb850CFM,
                    HolleyUltraXPCarb950CFM,
                    HolleyUltraAvengerCarb670CFM,
                    HolleyUltraAvengerCarb770CFM,
                    HolleyUltraAvengerCarb870CFM
                 );
            }
            context.SaveChanges();

       

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
