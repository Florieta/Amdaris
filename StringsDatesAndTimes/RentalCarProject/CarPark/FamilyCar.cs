using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class FamilyCar : Car, ICar
    {
        private const int NumberOfSeats = 5;
        private double fuelConsumption;
        private double capacity;

        public FamilyCar(string make, string model, string regNumber, int makeYear, int horsePower, string color, double fuelConsumption, double capacity)
            : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats)
        {
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
        }


        public double FuelConsumption
        {
            get => this.fuelConsumption;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid fuel consumption");
                }
                this.fuelConsumption = value;
            }
        }

        public double Capacity
        {
            get => this.capacity;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid capacity");
                }
                this.capacity = value;
            }
        }

        public double CalculateAvailableDistance(double FuelConsumption, double Capacity)
        {
            return Capacity / FuelConsumption * 100;
        }

        public override void VirtualNumberOfSeats(int NumberOfSeats)
        {
            base.VirtualNumberOfSeats(NumberOfSeats);
        }
    }
}
