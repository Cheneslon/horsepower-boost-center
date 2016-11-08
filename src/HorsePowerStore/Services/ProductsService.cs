using HorsePowerStore.Data;
using HorsePowerStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Services
{
    public class ProductsService
    {
        private ApplicationDbContext db;

        public ProductsService (ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Product> ListProducts (int start, int amount)
        {
            return db.Products.Skip(start).Take(amount).ToList();
        }
    }
}
