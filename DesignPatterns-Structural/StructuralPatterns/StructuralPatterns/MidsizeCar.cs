using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            this.Description = "Midsize Car";
        }

        public override double GetCarPrice() => 20000.00;

        public override string GetDescription() => Description;
    }
}
