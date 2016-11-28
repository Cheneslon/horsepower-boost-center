using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HorsePowerStore.Services;
using HorsePowerStore.Models;
using HorsePowerStore.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HorsePowerStore.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private CarsService carsService;

        public CarsController (CarsService carsService)
        {
            this.carsService = carsService;
        }

        [HttpGet]
        public IEnumerable<string> ListMakes()
        {
            return carsService.ListMakes();
        }
        
        [HttpGet("{make}")]
        public IEnumerable<string> ListMakeModels(string make)
        {
            return carsService.ListMakeModels(make);
        }

        [HttpGet("years/{model}")]
        public IEnumerable<int> ListModelYears (string model)
        {
            return carsService.ListModelYears(model);
        }

        [HttpGet("{make}/{model}/{year}")]
        public StylesViewModel GetStyles(string make, string model, int year)
        {
            return carsService.GetStyles(make, model, year);
        }
    }
}
