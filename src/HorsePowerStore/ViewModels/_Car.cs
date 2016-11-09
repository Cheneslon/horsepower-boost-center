using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{

    public class _Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        [Range(1900, 2100)]
        public int Year { get; set; }

        [Range(1, 5)]
        public int Doors { get; set; }

        public string Drive { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public List<Engine> CompatibleEngines { get; set; }
    }
}
