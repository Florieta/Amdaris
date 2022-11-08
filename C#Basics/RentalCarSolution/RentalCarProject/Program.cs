using RentalCarProject.CarPark;

Car car = new FamilyCar("Hundai", "i20", "В1234ВХ", 2022, 118, "grey", 50, 7.0);
car.VirtualNumberOfSeats(5);

SportsCar car1 = new SportsCar("Porsche", "Boxster", "Е1234АР", 2021, 217, "black", 64, 14.1);
SportsCar car2 = (SportsCar)car1.Clone();
