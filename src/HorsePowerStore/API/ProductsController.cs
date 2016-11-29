using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HorsePowerStore.Services;
using HorsePowerStore.Models;
using HorsePowerStore.ViewModels;
using Microsoft.AspNetCore.Authorization;

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
            return productsService.GetProductWithRatings(id, page * pageLength, pageLength, User.Identity.Name);
        }

        [Authorize]
        [HttpPost("addRating")]
        public void AddRating ([FromBody] RatingViewModel ratingViewModel)
        {
            var rating = new Rating()
            {
                Value = ratingViewModel.Value,
                Message = ratingViewModel.Message,
                Date = DateTime.Now
            };
            productsService.AddRating(ratingViewModel.ProductId, rating, User.Identity.Name);
        }

        [Authorize]
        [HttpPost("/removeRating")]
        public void RemoveRating([FromBody] int ratingId)
        {
            productsService.RemoveRating(ratingId, User.Identity.Name);
        }
    }
}
