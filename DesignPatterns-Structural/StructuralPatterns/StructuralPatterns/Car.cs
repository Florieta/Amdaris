using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Car
    {
        public string Description { get; set; } = null!;

        public abstract string GetDescription();

        public abstract double GetCarPrice();
    }
}
