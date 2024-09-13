// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajalt tema sugu
//Rakendus küsib kasutajalt tema perekonnanime
//"Welcome Mr . [Kasutaja perekonnaimi]" / "Welcome Ms...



Console.WriteLine("Please select youre gender (M/F):");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha stringi/sõne formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();   



if (userGender == 'M')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}    //kui üks võrdusmärk, siis ta salvestab, kui kaks, siis võrdleb
else if(userGender == 'F')
{
    Console.WriteLine($"Welcome, Mrs.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
