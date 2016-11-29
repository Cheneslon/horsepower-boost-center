using HorsePowerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public string PurchaseURL { get; set; }

        public List<RatingViewModel> Ratings { get; set; }
        public double AverageRating { get; set; }
        public int UserRating { get; set; }
    }
}
