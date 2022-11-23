using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CarDecorator : Car
    {
        protected Car car;

        public CarDecorator(Car car)
        {
            this.car = car;
        }

        public override double GetCarPrice() => car.GetCarPrice();

        public override string GetDescription() => car.GetDescription();
    }
}
