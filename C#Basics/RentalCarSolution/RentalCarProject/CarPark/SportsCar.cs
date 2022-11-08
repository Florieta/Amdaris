using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class SportsCar : Car, ICloneable
    {
        private const int NumberOfSeats = 2;

        public SportsCar(string make, string model, string regNumber, int makeYear, int horsePower, string color,
            double capacity, double consumption)
            : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats, capacity, consumption)
        {
        }

        public override void CountOfSeats(int NumberOfSeats)
        {
            base.CountOfSeats(NumberOfSeats);
        }

        public object Clone()
        {
            return (SportsCar)this.MemberwiseClone();
        }
    }
}
