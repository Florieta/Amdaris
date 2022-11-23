
using ObserverPattern;

//Create a Product with Out Of Stock Status
Subject app = new Subject("NiceApp", 10, "Out Of Stock");

//User John will be created and user1 object will be registered to the subject
Observer user1 = new Observer("John", app);

//User Emma will be created and user1 object will be registered to the subject
Observer user2 = new Observer("Emma", app);

//User Anna will be created and user3 object will be registered to the subject
Observer user3 = new Observer("Anna", app);

Console.WriteLine("NiceApp current state : " + app.getAvailability());
Console.WriteLine();

// Now product is available
app.setAvailability("Available");
Console.Read();

