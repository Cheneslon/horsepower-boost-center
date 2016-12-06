using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class CarModSelection
    {
        public int Id { get; set; }
        public CarMod CarMod { get; set; }
        public CarInstance CarInstance { get; set; }
    }
}
