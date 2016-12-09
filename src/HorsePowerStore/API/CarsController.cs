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
        public async Task<IEnumerable<string>> ListMakes()
        {
            return await carsService.ListMakes();
        }
        
        [HttpGet("{make}")]
        public async Task<IEnumerable<string>> ListMakeModels(string make)
        {
            return await carsService.ListMakeModels(make);
        }

        [HttpGet("years/{model}")]
        public async Task<IEnumerable<int>> ListModelYears (string model)
        {
            return await carsService.ListModelYears(model);
        }

        [HttpGet("{make}/{model}/{year}")]
        public async Task<StylesViewModel> GetStyles(string make, string model, int year)
        {
            return await carsService.GetStyles(make, model, year);
        }
    }
}
