using System;

// string name = "";

// while (name == "")
// {
//   Console.WriteLine("Skriv in ditt namn");
//   name = Console.ReadLine();
// }

// int i = 10;

// while (i > 0)
// {
//   Console.WriteLine(i);
//   i -= 1;
// }

string name = "";

while (name != "micke" && name != "martin")
{
  Console.WriteLine("Skriv ditt namn! Micke eller Martin");
  name = Console.ReadLine();

  name = name.ToLower();
  
}

int hpHero = 100;
int hpEnemy = 100;

while (hpHero > 0 && hpEnemy > 0)
{
  
}


Console.ReadLine();
