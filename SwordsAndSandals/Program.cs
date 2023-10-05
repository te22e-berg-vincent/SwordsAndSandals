// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;
int liv = 1;
int hhp = 500;
int vhp = 750;
int damage = 0;
int damage2 = 0;




int dmg2 = 0;
int hhhp = 550;
int vvhp = 900;

Random rand = new Random();
int chance = rand.Next(1, 4);

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
  Console.WriteLine($"{name} {hhp}hp Jurgen Blimp {vhp}hp");
  Console.ReadLine();
  damage2 = generator.Next(30, 175);
  vhp -= damage2;

  Console.WriteLine($"You slashed Jurgen Blimp and he has {vhp}hp left");
  Console.ReadLine();

  damage = generator.Next(30, 93);
  hhp -= damage;

  Console.WriteLine($"You were hit by Jurgen Blimp and have {hhp}hp left");

  Console.ReadLine();
}

if (vhp < 0 && hhp >0)
{
  Console.WriteLine("Congratulations yo beat xxx and came out victorious");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU WON");
  Console.WriteLine("You pciked up the opponents weapon.");
  Console.WriteLine("It's a big iron mase, A grat weapon for blunt force attacks but it's slow.");
  Console.WriteLine("A weapon with a higher risk and higher reward.");
  Console.WriteLine("Use it whisely in your next battle.");
  Console.ReadLine();
}

else if (hhp < 0 && vhp>0)
{
  Console.WriteLine("Unfortunately you were bested by xxx and lost the battle.");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU LOST");
  liv = 0;
  Console.ReadLine();
}

else if(vhp < 0 && hhp < 0)
{
  Console.WriteLine("It seems like you both struck each other at the same time.");
  Console.WriteLine("With your final strikes you both went down in battle.");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: TIE");
  liv = 0;
  Console.ReadLine();
}
if (liv >= 1)
{
  Console.WriteLine("NEXT BATTLE");
  Console.WriteLine("You will now enter the arena against Gorbino");
  Console.ReadLine();
   Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");
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
  if (val == "1" && chance < 2)
  {
    chance = rand.Next(1, 4);
    Console.WriteLine("YOU MISSED");
    Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");
 
    damage = generator.Next(30, 114);
    hhhp -= damage;
    Console.WriteLine("Gorbino used this opportunity to strike you");
    Console.ReadLine();
    Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");

   
  }

  else if (val == "1" && chance >= 1)
  {
chance = rand.Next(1, 4);
    dmg2 = generator.Next(30, 254);
    vvhp -= dmg2;

    Console.WriteLine("You struck Gorbino with your mase");
    Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");
    Console.ReadLine();
    damage = generator.Next(30, 98);
    hhhp -= damage;
    Console.WriteLine("Gorbino counter attacked");
    Console.ReadLine();
    Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");


  }
  else if (val == "2")
  {
    
        damage2 = generator.Next(50, 185);
    vvhp -= damage2;
    Console.WriteLine("You slashed Gorbino with your sword");
    Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");
    Console.ReadLine();

    damage = generator.Next(30, 189);
    hhhp -= damage;
    Console.WriteLine("Gorbino swung back against you");
    Console.ReadLine();
     Console.WriteLine($"{name} {hhhp}hp Gorbino {vvhp}hp");
   

  }
  if (vvhp > 0 && hhhp > 0) {
 Console.WriteLine("Chose your next attack");
  }

}


if (vvhp < 0 && hhhp > 0)
{
  Console.WriteLine("Congratulations you beat Gorbino and came out victorious");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU WON");
  Console.WriteLine("Thanks for playing");
  Console.ReadLine();
}

else if (hhhp < 0 && vvhp > 0)
{
  Console.WriteLine("Unfortunately you were bested by Gorbino and lost the battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: YOU LOST");
  Console.WriteLine("Thanks for playing");
  liv = 0;
  Console.ReadLine();
}

else if (vvhp <= 0 && hhhp <= 0)
{
  Console.WriteLine("It seems that you both struck each other at the same time");
  Console.WriteLine("With your final strikes you both went down in battle");
  Console.ReadLine();
  Console.WriteLine("MATCH RESULT: TIE");
  Console.WriteLine("Thanks for playing");
  liv = 0;
  Console.ReadLine();
}





