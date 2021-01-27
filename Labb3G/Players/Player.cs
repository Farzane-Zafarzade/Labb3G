using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.Players
{
    class Player:IPlayer
    {
        public string name { get; set; }
        private int hp = 100;
        private int level = 1;
        private int exp;
        private int attackdmg = 20;
        bool dead;

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Level { get => level; set => level = value; }
        public int Exp { get => exp; set => exp = value; }
        public bool Dead { get => dead; set => dead = value; }

        public int Attack() // run to attack
        {
            Console.WriteLine($"{this.name} attack!");
            return MyRandomHelper.RandomHelper.RandomNumber(10,attackdmg);  
        }

        public int TakeDamage(int attack) // calculate Hp after player take damage
        {
            hp = this.hp - attack;
            return this.hp;
        }

        public void PrintInfo() // show player's information
        {
            Console.Clear();
            Console.WriteLine(" \n\n* Details about your character *" );
            Console.WriteLine("==================================");
            Console.WriteLine($"        name  : {name}");
            Console.WriteLine($"        lavel : {level}");
            Console.WriteLine($"          hp  : {hp}");
            Console.WriteLine($"          exp : {exp}");
            Console.WriteLine("==================================\n\n");
        }

      
        public string GetName() //return player's Name
        {
            
           return this.name;
        }

        public int GetHp() //return player's Hp
        {
                
            return this.hp;
        }

        public int GetExp() //return player's Exp
        {
            return this.exp;
        }

        public int GetLevel() //return player's level
        {
            return this.level;
        }

        public bool IsDead() // check if player is dead
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

        public int GainExp(int monstersExp) // Gets monster's Exp to the player If the monster is killed 
        {
           return this.exp = this.exp + monstersExp;
        }

        public void LevelUp() // Increases player's level
        {
            this.level = this.level + 1;
        }
    }
}
