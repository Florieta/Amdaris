using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class EconomyCar : Car
    {
        public EconomyCar()
        {
            this.Description = "Economy Car";
        }

        public override double GetCarPrice() => 30000.00;

        public override string GetDescription() => Description;
    }
}
