using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HorsePowerStore.Models
{
    public enum Intake
    {
        SuperCharged,
        TurboCharged,
        NaturallyAspirated
    }

    public class Engine
    {
        public int Id { get; set; }
        public int Cylinders { get; set; }
        public decimal Volume { get; set; }
        public Intake Intake { get; set; }
        public decimal HorsePower { get; set; }
    }
}
