//----------------------------------------------------------------------------------------------------------------------
//Lambda expression before C# version 10
//----------------------------------------------------------------------------------------------------------------------

//Action<string, ConsoleColor> writeWithColor = (string s, ConsoleColor color) =>
//{
//    var originalColor = Console.ForegroundColor;
//    Console.ForegroundColor = color;
//    Console.WriteLine(s);
//    Console.ForegroundColor = originalColor;
//};

//Func<string, string> upper = (string s) => s.ToUpperInvariant();

//writeWithColor("Hello", ConsoleColor.Cyan);
//Console.WriteLine(upper("This should be default color"));
//writeWithColor("Bye", ConsoleColor.Yellow);

//Console.ReadLine();

//----------------------------------------------------------------------------------------------------------------------
//Lambda expression after C# version 10
//Now we can replace the "Action" and "Func" keywords for the "var" keyword
//----------------------------------------------------------------------------------------------------------------------

//var writeWithColor = (string s, ConsoleColor color) =>
//{
//    var originalColor = Console.ForegroundColor;
//    Console.ForegroundColor = color;
//    Console.WriteLine(s);
//    Console.ForegroundColor = originalColor;
//};

//var upper = (string s) => s.ToUpperInvariant();

//writeWithColor("Hello", ConsoleColor.Cyan);
//Console.WriteLine(upper("This should be default color"));
//writeWithColor("Bye", ConsoleColor.Yellow);

//Console.ReadLine();


//----------------------------------------------------------------------------------------------------------------------
// We use "Func" and "Action" in C# version 9
//----------------------------------------------------------------------------------------------------------------------
//Func<string> getUserInput = Console.ReadLine;
//Action<string> tellUser = (string s) => Console.WriteLine(s);
//Action waitForEnter = () => Console.ReadLine();

//tellUser("Please enter your name:");
//var name = getUserInput();
//tellUser($"Your name is {name}");
//waitForEnter();

//----------------------------------------------------------------------------------------------------------------------
// We use "Func" and "Action" in C# version 10
//----------------------------------------------------------------------------------------------------------------------

var getUserInput = Console.ReadLine;
var tellUser = (string s) => Console.WriteLine(s);
var waitForEnter = () => Console.ReadLine();

tellUser("Please enter your name:");
var name = getUserInput();
tellUser($"Your name is {name}");
waitForEnter();
