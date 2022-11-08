using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public class HybridCar : Car, IElectricCar
    {
        private const int NumberOfSeats = 5;
        private int batteryConsumption;
        private int capacityInHours;
        private double fuelConsumption;
        private double capacity;
        public HybridCar(string make, string model, string regNumber, int makeYear, int horsePower, string color,
            int batteryConsumption, int capacityInHours, double fuelConsumption, double capacity) 
            : base(make, model, regNumber, makeYear, horsePower, color, NumberOfSeats)
        {
            this.BatteryConsumption = batteryConsumption;
            this.CapacityInHours = capacityInHours;
            this.FuelConsumption = fuelConsumption;
            this.Capacity = capacity;
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
        public double CalculateTheAvailableDistance(double FuelConsumption, double Capacity)
        {
            return Capacity/FuelConsumption * 100;
        }

        public double CalculateTheAvailableDistance(int CapacityInHours, int BatteryConsumption)
        {
            return (double)CapacityInHours / batteryConsumption * 100;
        }

        

        public override void VirtualNumberOfSeats(int NumberOfSeats)
        {
            base.VirtualNumberOfSeats(NumberOfSeats);
        }
    }
}
