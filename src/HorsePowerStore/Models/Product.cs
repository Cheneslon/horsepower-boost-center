using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public string PurchaseURL { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
