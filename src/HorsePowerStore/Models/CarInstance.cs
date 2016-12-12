using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public class CarInstance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Style Style { get; set; }
        public List<CarModSelection> SelectedCarMods { get; set; }
    }
}
