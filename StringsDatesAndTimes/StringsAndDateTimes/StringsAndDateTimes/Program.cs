//Strings, Dates and Time
//-Use Join
using System.Globalization;

string[] bookedCars = new string[] { "Audi", "Ford", "Open", "Honda" };
Console.WriteLine(string.Join(", ", bookedCars));

//Use split

string carsMake = "Toyota, Mercedes, Honda, Open, Renault";
string[] cars = carsMake.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

//-Use DateTime and TimeSpan

DateTime start = DateTime.Now;
DateTime end = DateTime.Now.AddDays(7);
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


//Optional Assignment
WrongTags("<app><app><app></app></app>");
// => 1
WrongTags("<app></app></app><app><app>");
// => 3
WrongTags("</app><app><app></app></app>");
// => 1
static void WrongTags(string text)
{
    string[] tags = text.Split('>', StringSplitOptions.RemoveEmptyEntries).ToArray();
    int countOpenTag = 0;
    int countCloseTag = 0;
    int wrongTag = 0;

    foreach (string tag in tags)
    {
        if (tag.StartsWith("</"))
        {
            if (countCloseTag == countOpenTag)
            {
                wrongTag++;
            }
            else if (countOpenTag > countCloseTag)
            {
                countCloseTag += 1;
            }
            else
            {
                wrongTag++;
            }
        }
        else if (tag.StartsWith("<"))
        {
            countOpenTag += 1;
        }
    }

    if (countOpenTag == countCloseTag && wrongTag == 0)
    {
        Console.WriteLine("All coorect!");
    }
    else if (countOpenTag > countCloseTag)
    {
        var diff = countOpenTag - countCloseTag;
        wrongTag += diff;
        Console.WriteLine($"You have {wrongTag} wrong tags!");
    }
    else
    {
        Console.WriteLine($"You have {wrongTag} wrong tags!");
    }
}
