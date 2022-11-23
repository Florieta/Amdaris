using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Navigation : CarDecorator
    {
        public Navigation(Car car)
            : base(car)
        {
            this.Description = "Navigation";
        }

        public override string GetDescription() => $"{car.GetDescription()}, {Description}";

        public override double GetCarPrice() => car.GetCarPrice() + 5000;
    }
}
