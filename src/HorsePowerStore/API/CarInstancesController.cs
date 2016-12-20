using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HorsePowerStore.Models;
using HorsePowerStore.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HorsePowerStore.API
{
    [Route("api/[controller]")]
    [Authorize]
    public class CarInstancesController : Controller
    {
        private CarInstancesService carInstancesService;

        public CarInstancesController (CarInstancesService carInstancesService)
        {
            this.carInstancesService = carInstancesService;
        }

        [HttpGet("{id}")]
        public CarInstance GetCarInstance(int id)
        {
            return carInstancesService.Get(id, User.Identity.Name);
        }

        [HttpGet]
        public List<CarInstance> GetUserCarInstances ()
        {
            return carInstancesService.GetUserSaved(User.Identity.Name);
        }

        [HttpPost]
        public void SaveCarInstance ([FromBody] CarInstance carInstance)
        {
            carInstancesService.Save(carInstance, User.Identity.Name);
        }

        [HttpPost("overwrite")]
        public void OverwriteCarInstance ([FromBody] CarInstance carInstance)
        {
            carInstancesService.Overwrite(carInstance, User.Identity.Name);
        }

        [HttpPost("delete/{id}")]
        public void DeleteCarInstance(int id)
        {
            carInstancesService.Delete(id, User.Identity.Name);
        }
    }
}
