string name = "Randall", location = "Utah";

Console.WriteLine("\tMy name is " + name);
Console.WriteLine("\tI am from " + location);

Console.WriteLine("\tToday's date is " + DateTime.Today.ToShortDateString());

TimeSpan christmas = DateTime.Parse("12/25/2023") - DateTime.Now;

Console.WriteLine("\tThere are " + christmas.Days.ToString() + " days until Christmas.");

Console.WriteLine("\n\tPress any key to initialize glass glazing subroutine:");
Console.ReadKey();

Console.WriteLine("\nNow initializing the glass glazing subroutine.");
Thread.Sleep(500);
Console.Write("\t.");
Thread.Sleep(500);
Console.Write(" .");
Thread.Sleep(500);
Console.Write(" .");
Thread.Sleep(500);
Console.Write(" .");
Thread.Sleep(500);
Console.Write(" .");
Thread.Sleep(500);

static void GlazerCalc()
{
    double width, height, woodLength, glassArea; 
    string widthString, heightString;
    Console.Write("\nPlease enter the width of your glass in meters: ");
    widthString = Console.ReadLine(); 
    width = double.Parse(widthString);

    Console.Write("\nPlease enter the height of your glass in meters: ");
    heightString = Console.ReadLine(); 
    height = double.Parse(heightString); 

    woodLength = 2 * (width + height) * 3.25; 
    glassArea = 2 * (width * height); 

    Console.WriteLine("\nThe length of the wood is " + woodLength + " feet"); 
    Console.WriteLine("The area of the glass is " + glassArea + " square meters");
}

GlazerCalc();

Console.Write("\nPress any key to exit this program: ");
Console.ReadKey();
Console.WriteLine();