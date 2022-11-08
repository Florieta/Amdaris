using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class MiniVan : Car
    {
        private const int NumberOfSeats = 9;

        public MiniVan(string make, string model, string regNumber, int makeYear, int horsePower, string color,
            double capacity, double consumption) 
            : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats, capacity, consumption)
        {
        }

        public override void CountOfSeats(int NumberOfSeats)
        {
            base.CountOfSeats(NumberOfSeats);
        }

    }
}
