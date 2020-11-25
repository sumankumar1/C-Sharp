using System;

namespace OOPgame
{
    class Warrior
    {
        internal string name;
        internal double health;
        internal double maxAttack;
        internal double maxBlock;

        public Warrior(string name, double health, double maxAttack, double maxBlock)
        {
            this.name = name;
            this.health = health;
            this.maxAttack = maxAttack;
            this.maxBlock = maxBlock;
        }

        internal double Attack()
        {
            Random rnd = new Random();
            return rnd.NextDouble() * maxAttack;
        }

        internal double Block()
        {
            Random rnd = new Random();
            return rnd.NextDouble() * maxAttack;
        }

    }
}
