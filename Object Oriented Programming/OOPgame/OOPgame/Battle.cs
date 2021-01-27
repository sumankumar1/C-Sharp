using System;
using System.Collections.Generic;
using System.Text;

namespace OOPgame
{
    class Battle
    {
        internal static void StartFight(Warrior warriorA, Warrior warriorB)
        {
            Random rnd = new Random();
            int Toss = rnd.Next(2);
            if (Toss==0)
            {
                Console.WriteLine("Warrior {0} has won the toss and will attack first", warriorA.name);
            }
            else
            {
                Console.WriteLine("Warrior {0} has won the toss and will attack first", warriorB.name);
            }
            
            while (warriorA.health>0 && warriorB.health>0)
            {
                if (Toss==0)
                {                   
                    GetAttackResult(ref warriorA, ref warriorB);                    
                }
                else
                {
                    GetAttackResult(ref warriorB, ref warriorA);
                }
                
            }
        }

        internal static void GetAttackResult(ref Warrior warriorA,ref Warrior warriorB)
        {
            double damage;
            damage =  warriorA.Attack() -  warriorB.Block();
            damage = damage > 0 ? damage : 0;
             warriorB.health -= damage;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0} attacked {1}. Damage done {2,-5:0.00}. Current health is {3,-5:0.00}.",
                 warriorA.name, warriorB.name,damage, warriorB.health);

            if ( warriorB.health > 0)
            {
                damage =  warriorB.Attack() -  warriorA.Block();
                damage = damage > 0 ? damage : 0;
                warriorA.health -= damage;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("{0} attacked {1}. Damage done {2,-5:0.00}. Current health is {3,-5:0.00}.",
                         warriorB.name,  warriorA.name, damage,  warriorA.health);
                if (warriorA.health<0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Warrior {0} has died.", warriorA.name);
                    Console.WriteLine("Warrior {0} Won.", warriorB.name);
                }

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Warrior {0} has died",  warriorB.name);
                Console.WriteLine("Warrior {0} Won.", warriorA.name);
            }
        }

    }
}
