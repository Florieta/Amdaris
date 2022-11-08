using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class ElectricCar : Car
    {
        private const int NumberOfSeats = 5;

        public ElectricCar(string make, string model, string regNumber, int makeYear, int horsePower, string color, int seats,
            double capacity, double consumption) : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats, capacity, consumption)
        {
        }

        public override void CountOfSeats(int NumberOfSeats)
        {
            base.CountOfSeats(NumberOfSeats);
        }
    }
}
