namespace Labb3G.Players
{
    using System;

    internal class Player : IPlayer
    {
        public string name { get; set; }

        private int hp = 100;

        private int level = 1;

        private int exp;

        private int attackdmg = 20;

        internal bool dead;

        public string Name { get => name; set => name = value; }

        public int Hp { get => hp; set => hp = value; }

        public int Level { get => level; set => level = value; }

        public int Exp { get => exp; set => exp = value; }

        public bool Dead { get => dead; set => dead = value; }

        // run the attack
        public int Attack() 
        {
            Console.WriteLine($"{this.name} attack!");
            return MyRandomHelper.RandomHelper.RandomNumber(10, attackdmg);
        }

        // calculate Hp after player take damage
        public int TakeDamage(int attack) 
        {
            hp = this.hp - attack;
            return this.hp;
        }

        // show player's information
        public void PrintInfo() 
        {
            Console.Clear();
            Console.WriteLine(" \n\n* Details about your character *");
            Console.WriteLine("==================================");
            Console.WriteLine($"        name  : {name}");
            Console.WriteLine($"        lavel : {level}");
            Console.WriteLine($"          hp  : {hp}");
            Console.WriteLine($"          exp : {exp}");
            Console.WriteLine("==================================\n\n");
        }

        //return player's Name
        public string GetName() 
        {

            return this.name;
        }

        //return player's Hp
        public int GetHp() 
        {

            return this.hp;
        }

        //return player's Exp
        public int GetExp() 
        {
            return this.exp;
        }

        //return player's level
        public int GetLevel() 
        {
            return this.level;
        }

        // check if player is dead
        public bool IsDead() 
        {
            if (this.hp > 0)
            {
                this.dead = false;
            }

            else
            {
                this.dead = true;
            }
            return this.dead;
        }

        // Gets monster's Exp to the player If the monster is killed
        public int GainExp(int monstersExp) 
        {
            return this.exp = this.exp + monstersExp;
        }

        // Increases player's level
        public void LevelUp() 
        {
            this.level = this.level + 1;
        }
    }
}
