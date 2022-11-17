
using FilesAndStreams.Models;
using System.IO.Compression;
using System.Security.Cryptography;

List<Vehicle> cars = new();
List<Vehicle> others = new();

String file = @"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\Cars.txt";

using (StreamReader stream = new StreamReader(file))
{
    while (stream.EndOfStream != true)
    {
        string[] line = stream.ReadLine().Split(',');
        if (line[2] == "Car")
        {
            cars.Add(new Vehicle(line[0], line[1], line[2]));
        }
        else
        {
            others.Add(new Vehicle(line[0], line[1], line[2]));
        }
    }
}

Console.WriteLine("Cars:");
foreach (var car in cars)
{
    Console.WriteLine(car.CarInfo);
}

Console.WriteLine();

Console.WriteLine("Other Vehicles:");
foreach (var vehicle in others)
{
    Console.WriteLine(vehicle.CarInfo);
}

// Save the list of cars to a file 
try
{
    using (StreamWriter sw = new StreamWriter(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\CarsOnly.txt"))
    {
        foreach (var car in cars)
        {
            sw.WriteLine(cars.ToString());
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Save the list of other vehicles to a file 
try
{
    using (StreamWriter sw = new StreamWriter(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\Others.txt"))
    {
        foreach (var vehicle in others)
        {
            sw.WriteLine(vehicle.ToString());
        }
    }   
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Encrypt cars file
try
{
    using (Aes aes = Aes.Create())
    {
        using (FileStream fs = new FileStream(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\CarsOnly.txt", FileMode.OpenOrCreate))
        {
            using (FileStream fsEncrypt = new FileStream(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\EncCars.txt", FileMode.OpenOrCreate))
            {
                using (CryptoStream cs = new CryptoStream(fsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    fs.CopyTo(cs);
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Use GZip compression for other vehicles file
try
{
    using (FileStream fs = new FileStream(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\Others.txt", FileMode.OpenOrCreate))
    {
        using (FileStream fsCompress = new FileStream(@"D:\SoftUni\source\Amdaris\FileSystemsAndStreams\FilesAndStreams\Vehicles\CompressOthers.txt", FileMode.OpenOrCreate))
        {
            using (GZipStream gs = new GZipStream(fsCompress, CompressionMode.Compress))
            {
                fs.CopyTo(gs);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}