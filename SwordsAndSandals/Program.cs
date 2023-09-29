// See https://aka.ms/new-console-template for more information


// Metod = förskapad bit kod som återanvänds
/*
Console.WriteLine("hey");

Console.ReadLine();


Dsds();
Console.ReadLine();

static void Dsds()
{
Console.WriteLine("hello");
}

*/

using System.Text.RegularExpressions;

int hhp = 500;
int vhp = 750;
int damage = 0;
int damage2 =0;


Console.WriteLine("Hello player.");
Console.WriteLine("Please select your name.");

string name = "";


name = Console.ReadLine();

Console.WriteLine($"Welcome {name} ");
Console.WriteLine("You will now go up against  in a fight the the DEATH");

Random generator = new Random();

while (hhp > 0 && vhp > 0)

{
Console.WriteLine($"{name} {hhp}hp xxxx {vhp}hp");
Console.ReadLine();
damage2 = generator.Next(20,199);
vhp -= damage2;

Console.WriteLine($"You hit xxx and he has {vhp}hp left");
Console.ReadLine();

damage = generator.Next(30,131);
hhp -=damage;

Console.WriteLine($"You were hit by xxx and have {hhp}hp left");

Console.ReadLine();
}

if (vhp < 0)
{  
    Console.WriteLine("Congratulations yo beat xxx and came out victorious");
Console.ReadLine();
Console.WriteLine("MATCH RESULT: YOU WON");
Console.ReadLine();
}

else if (hhp < 0) {  
Console.WriteLine("Unfortunately you were bested by xxx and lost the battle");
Console.ReadLine();
Console.WriteLine("MATCH RESULT: YOU LOST");
Console.ReadLine();
  }

else
{
Console.WriteLine("It seems that you both struck each other at the same time");
Console.WriteLine("With your final strikes you both went down in battle");
Console.ReadLine();
Console.WriteLine("MATCH RESULT: TIE");
Console.ReadLine();
}

