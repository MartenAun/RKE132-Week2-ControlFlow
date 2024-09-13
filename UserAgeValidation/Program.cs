// See https://aka.ms/new-console-template for more information



Console.WriteLine("Enter your age:");
//int userAge = Int32.Parse(Console.ReadLine());

string userAge = Console.ReadLine();

int userAgenum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgenum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAge}.");

if (isAgeNumber == true) 
{
    if (userAgenum >= 13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instaram!");
    }
}
else
{
    Console.WriteLine("Could not read your age...");
}



//if (userAge >= 13)
//{
//  Console.WriteLine("Welcome to instagram!");
//}


//else
//  {
//Console.WriteLine("You are too young to use instagram");
//}