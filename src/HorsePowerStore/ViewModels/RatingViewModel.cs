using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.ViewModels
{
    public class RatingViewModel
    {
        [Range(1, 5)]
        public int Value { get; set; }
        public string Message { get; set; }
        public int ProductId { get; set; }
    }
}
