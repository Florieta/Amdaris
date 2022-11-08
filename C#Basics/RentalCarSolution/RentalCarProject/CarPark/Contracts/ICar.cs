using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCarProject.CarPark.Contracts
{
    public interface ICar
    {
        double FuelConsumption { get; }

        double Capacity { get; }
      

        double CalculateAvailableDistance(double FuelConsumption, double Capacity);
    }
}
