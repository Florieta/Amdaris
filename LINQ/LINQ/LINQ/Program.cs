using LINQ;


var cars = new List<Car>
            {
                new Car { Id = 1, Make = "Hundai", Model = "i20", MakeYear = 2022, Color = "Grey", RegNumber = "CA5473T"},
                new Car { Id = 2, Make = "Porsche", Model = "Boxster", MakeYear = 2022, Color = "Black", RegNumber = "CA5421O"},
                new Car { Id = 3, Make = "Toyota", Model = "Auris", MakeYear = 2020, Color = "Black", RegNumber = "В5421ТX"},
                new Car { Id = 4, Make = "Kia", Model = "Seed", MakeYear = 2021, Color = "Blue", RegNumber = "CA1121B"},
                new Car { Id = 5, Make = "Toyota", Model = "Corola", MakeYear = 2022, Color = "Black", RegNumber = "В5434X"},
                new Car { Id = 6, Make = "Kia", Model = "Seed", MakeYear = 2019, Color = "White", RegNumber = "CA6721B"},
            };

//Method syntax

var blackCars = cars
    .Where(c => c.Color == "Black")
    .OrderBy(c => c.MakeYear)
    .ThenByDescending(c => c.Id);

var allToyotaCars = cars
    .Where(c => c.Make == "Toyota")
    .Select(c => new
    {
        Model = c.Model,
        MakeYear = c.MakeYear,
        RegNumber = c.RegNumber
    })
    .OrderByDescending(c => c.MakeYear)
    .ToList();

var car1 = cars
    .Where(c => c.Make == "Porsche")
    .FirstOrDefault();

var car2 = cars
    .Any(c => c.MakeYear == 2022);

var GroupByMake = cars.GroupBy(s => s.Make)
                            .OrderByDescending(c => c.Key)
                            .Select(std => new
                            {
                                Key = std.Key,
                                Cars = std.OrderBy(x => x.Model)
                            });

var firstThreeCars = cars.Where(c => c.MakeYear == 2022).Take(3).OrderByDescending(c => c.MakeYear);

var reversedCars = cars.Where(c => c.Color == "Black").Reverse();

//Query sintax

var filteredCars = from c in cars where c.Make.Contains("T") && c.Make.Contains("K") select c.Make;

var filteredCars2 = cars.Where(c => {
    Console.WriteLine($"Trying to filter: {c}");
    return c.Model.Contains("A") && c.Model.Contains("S");
});