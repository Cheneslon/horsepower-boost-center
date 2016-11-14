using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class ProductSelection
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public CarInstance CarInstance { get; set; }
    }
}
