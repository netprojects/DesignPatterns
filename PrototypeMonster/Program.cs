// See https://aka.ms/new-console-template for more information
Mummy mummy = new Mummy {Id = 1};
Vampire vampire = new Vampire {Id = 2};
Zombie zombie = new Zombie {Id = 3};

mummy.Attak();
vampire.Attak();
zombie.Attak();

Console.WriteLine("Clonables");

Mummy mummyClonable = (Mummy)mummy.Clone();
Vampire vampireClonable = (Vampire)vampire.Clone();
Zombie zombieClonable = (Zombie)zombie.Clone();

mummyClonable.Attak();
vampireClonable.Attak();
zombieClonable.Attak();