using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car)
            : base(car)
        {
            this.Description = "Sunroof";
        }

        public override string GetDescription() => $"{car.GetDescription()}, {Description}";

        public override double GetCarPrice() => car.GetCarPrice() + 2500;
    }
}
