using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class Year
    {
        public int Id { get; set; }
        public int Years { get; set; }
        public List<Style> Styles { get; set; }
    }
}
