string name;
string age;
string country;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("skriv in ditt namn: ");
name = Console.ReadLine();
;
Console.WriteLine("Hur gammal är du?: ");
age = Console.ReadLine();

Console.WriteLine("Vart kommer du ifrån?");
country = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("Hello " + name + "!");
 Console.WriteLine($"Hej {name} från {country}! Du är {age} år gammal");

Console.ReadLine();
