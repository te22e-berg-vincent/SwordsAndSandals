// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;
int liv = 1;
int hhp = 500;
int vhp = 750;
int damage = 0;
int damage2 = 0;



int vdmg = 0;
int dmg2 = 0;
int dmg1 = 0;
int hhhp = 550;
int vvhp = 1100;

Random rand = new Random();
int chance = rand.Next(1, 5);

Console.WriteLine("Hello Gladiator.");
Console.WriteLine("Please select your name.");

string name = "";
string val = "";

name = Console.ReadLine();

Console.WriteLine($"Welcome {name} ");
Console.WriteLine("You will now go up against in a fight the the DEATH");
Console.WriteLine("Your only weapon will be this dull iron sword");
Random generator = new Random();

while (hhp > 0 && vhp > 0)

{
  Console.WriteLine($"{name} {hhp}hp xxxx {vhp}hp");
  Console.ReadLine();
  damage2 = generator.Next(20, 199);
  vhp -= damage2;

  Console.WriteLine($"You hit xxx and he has {vhp}hp left");
  Console.ReadLine();

  damage = generator.Next(30, 101);
  hhp -= damage;

  Console.WriteLine($"You were hit by xxx and have {hhp}hp left");

  Console.ReadLine();
}

if (vhp < 0)
{
  Console.WriteLine("Congratulations yo beat xxx and came out victorious");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU WON");
  Console.WriteLine("You pciked up tho opponents weapon.");
  Console.WriteLine("It's a big iron mase, A grat weapon for blunt force attacks but it's slow.");
  Console.WriteLine("A weapon with a high risk and high reward.");
  Console.WriteLine("Use it whisely in your next battle");
  Console.ReadLine();
}

else if (hhp < 0)
{
  Console.WriteLine("Unfortunately you were bested by xxx and lost the battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU LOST");
  liv = 0;
  Console.ReadLine();
}

else if (vhp <= 0 && hhp <= 0)
{
  Console.WriteLine("It seems that you both struck each other at the same time");
  Console.WriteLine("With your final strikes you both went down in battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: TIE");
  liv = 0;
  Console.ReadLine();
}
if (liv >= 1)
{
  Console.WriteLine("NEXT BATTLE");
  Console.WriteLine("You will now enter the arena against xxxx");
  Console.ReadLine();
  Console.WriteLine("Press (1) to use your mase and (2) to use the sword ");

}
else if (liv <= 0)
{
Console.ReadLine();

}

while (hhhp > 0 && vvhp > 0)
{

  val = Console.ReadKey().KeyChar.ToString();
  if (val == "1" && chance >= 1)
  {
    Console.WriteLine("YOU MISSED");
    Console.WriteLine($"{name} {hhhp}hp xxxx {vvhp}hp");
    Console.ReadLine();

    Console.WriteLine($"{name} {hhhp}hp xxxx {vvhp}hp");
    Console.ReadLine();
    dmg2 = generator.Next(30, 119);
    hhhp -= dmg2;

  }

  else if (val == "1" && chance >= 1)
  {

    dmg2 = generator.Next(60, 249);
    vvhp -= dmg2;
    Console.WriteLine($"You hit xxx and he has {vvhp}hp left");
    Console.ReadLine();

    Console.WriteLine($"{name} {hhhp}hp xxxx {vvhp}hp");
    Console.ReadLine();
    damage = generator.Next(30, 119);
    hhhp -= damage;

  }
  else if (val == "2")
  {
    Console.WriteLine($"{name} {hhhp}hp xxxx {vvhp}hp");
    Console.ReadLine();
    damage2 = generator.Next(20, 199);
    vvhp -= damage2;

    Console.WriteLine($"You hit xxx and he has {vvhp}hp left");
    Console.ReadLine();
  }

}


if (vvhp < 0)
{
  Console.WriteLine("Congratulations yo beat xxx and came out victorious");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU WON");
  Console.ReadLine();
}

else if (hhhp < 0)
{
  Console.WriteLine("Unfortunately you were bested by xxx and lost the battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU LOST");
  liv = 0;
  Console.ReadLine();
}

else if (vvhp <= 0 && hhhp <= 0)
{
  Console.WriteLine("It seems that you both struck each other at the same time");
  Console.WriteLine("With your final strikes you both went down in battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: TIE");
  liv = 0;
  Console.ReadLine();
}





