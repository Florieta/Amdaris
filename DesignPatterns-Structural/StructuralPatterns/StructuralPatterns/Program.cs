using Decorator;

Car compactCar = new CompactCar();
compactCar = new Navigation(compactCar);
compactCar = new Sunroof(compactCar);
compactCar = new LeatherSeats(compactCar);

Console.WriteLine(compactCar.GetDescription());
Console.WriteLine($"{compactCar.GetCarPrice():C2}");
