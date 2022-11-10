
using ExceptionHandlingAndDebugging;
//First - Checks input arguments and throw exceptions
string[] values =
               {
                "-1,035.77219",
                "upss",
                "6.34",
                "120",
                "-22.7",
                "1",
                "hahah",
                "1.29e325",
            };

double result;

foreach (string value in values)
{
    try
    {
        result = Convert.ToDouble(value);
        if (double.IsPositiveInfinity(result) || double.IsNegativeInfinity(result))
        {
            throw new OverflowException();
        }
        Console.WriteLine($"Converted '{value}' to {result}.");
    }
    catch (FormatException)
    {
        Console.WriteLine($"Unable to convert '{value}' to a Double.");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"'{value}' is outside the range of a Double.");
    }
}

//Second - Custom Exception

Student student1 = new Student("Pesho", "pesho@abv.bg");

try
{
    Student student2 = new Student("P1sho", "pesho@abv.bg");
}
catch (Exception ex)
{
    throw new InvalidPersonNameException(ex.Message);
}



//Third Try-finally block
TestTryFinally("7");
TestTryFinally("abc");


static void TestTryFinally(string str)
{
    Console.WriteLine("Code before try-finally.");

    try
    {

        int.Parse(str);
        Console.WriteLine("Parsing was successfull.");
    }
    catch (FormatException)
    {
        Console.WriteLine("Parsing failed!");
    }
    finally
    {
        Console.WriteLine("The cleanup code is always executed!");
    }
}

//Forth - Rethrow ex

try
{
    Student student3 = new Student("P1sho", "pesho@abv.bg");
}
catch (Exception)
{
    Console.WriteLine("Invalid name!");
    throw;
}


//

//Console.WriteLine("Commands:");
//Console.WriteLine("1 - Send a request");
//Console.WriteLine("2 - Check for new messages");
//#if DEBUG
//Console.WriteLine("3 - Push the little red button");
//#endif

//var command = Console.ReadLine();

//switch (command)
//{
//    case "1":
//        SendRequest();
//        break;
//    case "2":
//        CheckForNewMessages();
//        break;
//#if DEBUG
//    case "3":
//        PushTheLittleRedButton();
//        break;
//#endif
//}
