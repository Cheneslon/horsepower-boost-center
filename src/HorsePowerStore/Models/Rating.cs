using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class Rating
    {
        public int Id { get; set; }

        // Numbers correspond to stars
        [Range(1, 5)]
        public int Value { get; set; }

        // Creation date
        public DateTime Date { get; set; }
    }
}
