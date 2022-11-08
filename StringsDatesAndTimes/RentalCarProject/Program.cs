using RentalCarProject.Booking;
using RentalCarProject.CarPark;
using System.Globalization;

//Basics C#
Car car = new FamilyCar("Hundai", "i20", "В1234ВХ", 2022, 118, "grey", 50, 7.0);
car.VirtualNumberOfSeats(5);

SportsCar car1 = new SportsCar("Porsche", "Boxster", "Е1234АР", 2021, 217, "black", 64, 14.1);
SportsCar car2 = (SportsCar)car1.Clone();

//Strings, Dates and Time
//-Use Join
string[] bookedCars = new string[] { car.Model, car1.Model, car2.Model };
Console.WriteLine(string.Join(", ", bookedCars));

//Use split

string carsMake = "Toyota, Mercedes, Honda, Open, Renault";
string[] cars = carsMake.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

//-Use DateTime and TimeSpan
Booking booking = new Booking();
DateTime start = booking.PickUpDateAndTime = DateTime.Now;
DateTime end = booking.DropOffDateAndTime = DateTime.Now.AddDays(7);
TimeSpan difference = end - start;
Console.WriteLine(difference.Days);

//-Use DateTimeOffset

DateTime startDate = new DateTime(2022, 11, 8, 8, 30, 0);
DateTimeOffset targetTime;

DateTime utcTime = DateTime.SpecifyKind(startDate, DateTimeKind.Utc);
targetTime = new DateTimeOffset(utcTime);
Console.WriteLine(targetTime);

//-Use CultureInfo
string newDate = "20/08/2022";
bool isStartDateValid = DateTime.TryParseExact(newDate, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime openDate);

if (!isStartDateValid)
{
    Console.WriteLine("Wrong format");
}
else
{
    Console.WriteLine("Good job!");
}

