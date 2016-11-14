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
    public class ProductsController : Controller
    {
        private int pageLength = 50;
        private ProductsService productsService;

        public ProductsController(ProductsService productsService)
        {
            this.productsService = productsService;
        }

        // GET: api/values
        [HttpGet("pages/{page}")]
        public List<ProductViewModel> ListProducts(int page)
        {
            return productsService.ListProducts(page * pageLength, pageLength);
        }

        [HttpGet("{id}/ratings/{page}")]
        public ProductViewModel GetProductWithRatings(int id, int page)
        {
            return productsService.GetProductWithRatings(id, page * pageLength, pageLength);
        }
    }
}
