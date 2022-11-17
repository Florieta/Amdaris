using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesAndStreams.Models
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string CarInfo { get { return $"{Make} {Model} {Type}"; } }

        public Vehicle(string make, string model, string type)
        {
            Make = make;
            Model = model;
            Type = type;

        }

        public override string ToString()
        {
            return $"{Make} {Model} {Type}";
        }

    }
}
