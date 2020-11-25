using System;

namespace OOPgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1, name2;
            double health, maxAttack, maxBlock;
            
            Console.Write("Enter First Warrior Name:");
            name1 = Console.ReadLine();
            Console.Write("Enter Second Warrior Name:");
            name2 = Console.ReadLine();
            Console.Write("Enter Warrior Health:");
            health = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Warrior's Maximum Attack strength:");
            maxAttack = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Warrior's Maximum Block strength:");
            maxBlock = Convert.ToDouble(Console.ReadLine());

            //Warrior maximus = new Warrior("Maximus", 1000, 120, 40);
            Warrior maximus = new Warrior(name1, health, maxAttack, maxBlock);

            //Warrior bob = new Warrior("Bob", 1000, 120, 40);
            Warrior bob = new Warrior(name2, health, maxAttack, maxBlock);


            Console.WriteLine("\n\n                           PRESS ANY KEY TO START MORTAL COMBAT \n\n");
            Console.ReadKey();
            ConsoleKeyInfo cki;
            while (true)
            {
                Battle.StartFight(maximus, bob);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Enter to Rematch or Esc to Exit:");
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Escape)
                {
                    break;
                }
                maximus.health = health;
                bob.health = health;
                Console.BackgroundColor = ConsoleColor.Black;
                //Console.ReadLine();
            }

        }
    }
}
