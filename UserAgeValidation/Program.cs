// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutajal valida tema sugu (m/f)
//Rakendus küsib kasutajal sisestada tema perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]

Console.WriteLine("Please select Your gender (m/f):");
char userGender = char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter Your last name:");
string  userLastName = Console.ReadLine();

if(userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
