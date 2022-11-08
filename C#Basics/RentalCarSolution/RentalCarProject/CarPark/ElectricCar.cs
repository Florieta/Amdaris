using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class ElectricCar : Car, IElectricCar
    {
        private const int NumberOfSeats = 5;
        private int batteryConsumption;
        private int capacityInHours;
        public ElectricCar(string make, string model, string regNumber, int makeYear, int horsePower, string color,
            int batteryConsumption, int capacityInHours) 
            : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats)
        {
            BatteryConsumption = batteryConsumption;
            CapacityInHours = capacityInHours;
        }
        
        public int BatteryConsumption
        {
            get => this.batteryConsumption;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid battery consumption");
                }
                this.batteryConsumption = value;
            }
        }

        public int CapacityInHours
        {
            get => this.capacityInHours;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid capacity");
                }
                this.capacityInHours = value;
            }
        }

        public double CalculateTheAvailableDistance(int CapacityInHours, int BatteryConsumption)
        {
            return (double)CapacityInHours / BatteryConsumption * 100;
        }

        public override void VirtualNumberOfSeats(int NumberOfSeats)
        {
            base.VirtualNumberOfSeats(NumberOfSeats);
        }

       
    }
}
