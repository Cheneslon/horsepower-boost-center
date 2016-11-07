using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class Engine
    {
        public int Id { get; set; }
        public int Cylinders { get; set; }
        public decimal Volume { get; set; }
        public decimal Intake { get; set; }
        public decimal HorsePower { get; set; }
    }
}
