using RentalCarProject.CarPark.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark
{
    public abstract class Car : ICar
    {
        private string make;
        private string model;
        private string regNumber;
        private int horsePower;
        private int makeYear;
        private int seats;
        private string color;
        private double capacity;
        private double consumption;

        protected Car(string make, string model, string regNumber, int makeYear, int horsePower, string color, int seats,
            double capacity, double consumption)
        {
            this.Make = make;
            this.Model = model;
            this.RegNumber = regNumber;
            this.HorsePower = horsePower;
            this.MakeYear = makeYear;
            this.Color = color;
            this.Seats = seats;
            this.Capacity = capacity;
            this.Consumption = consumption;
        }

        public string Make
        {
            get => this.make;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid car make!");
                }
                this.make = value;
            }
        }

        public string Model
        {
            get => this.model;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid car model");
                }

                this.model = value;
            }
        }

        public string RegNumber
        {
            get => this.regNumber;

            private set
            {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Invalid car registration number");
                }

                this.regNumber = value;
            }
        }

        public int HorsePower
        {
            get => this.horsePower;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid car horse power");
                }
                this.horsePower = value;
            }
        }

        public int MakeYear
        {
            get => this.makeYear;

            private set
            {
                if (value < 2010)
                {
                    throw new ArgumentException("Invalid year of make");
                }
                this.makeYear = value;
            }
        }

        public int Seats
        {
            get => this.seats;

            private set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Invalid number of seats");
                }
                this.seats = value;
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

        public double Consumption
        {
            get => this.consumption;

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid consumption");
                }
                this.consumption = value;
            }
        }
        public string Color { get; }

        public virtual double CalculateAvailableDistance()
        {
            return Capacity / Consumption * 100;
        }

        public virtual void CountOfSeats(int seats)
        {
            Console.WriteLine("The {0} has {1} number of seats.", this.GetType().Name, seats);
        }
    }
}
