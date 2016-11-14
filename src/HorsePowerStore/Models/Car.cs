using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public enum Drive
    {
        TwoWheel,
        FourWheel
    }

    public enum Transmission
    {
        Manual,
        Automatic
    }

    public enum Fuel
    {
        Gasoline, 
        Diesel,
        Electric
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        [Range(1900, 2100)]
        public int Year { get; set; }

        [Range(1, 5)]
        public int Doors { get; set; }

        public Drive Drive { get; set; }
        public Transmission Transmission { get; set; }
        public Fuel Fuel { get; set; }
        public List<EngineInstall> EngineInstalls { get; set; }
    }
}
