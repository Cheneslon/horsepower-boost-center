using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class Year
    {
        public int Id { get; set; }
        [Range(1900, 2100)]
        public int Years { get; set; }
        public List<Style> Styles { get; set; }
    }
}
