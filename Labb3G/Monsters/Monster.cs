using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.Monsters
{
    abstract class Monster : IMonster
    {
        private string name;
        private int hp;
        private int exp;
        private int attackDmg;
        bool dead;
        

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Exp { get => exp; set => exp = value; }
        public int AttackDmg { get => attackDmg; set => attackDmg = value; }
        public bool Dead { get => dead; set => dead = value; }
       


        public virtual int Attack() //Runs to attack
        {
            return MyRandomHelper.RandomHelper.RandomNumber(5, attackDmg);
        }

        public virtual void TakeDamage(int attack) // Calculates Hp after monster takes damage
        {
            hp = this.hp - attack;
        }

        public virtual string GetName() //Returns monster's Name
        {
            return this.name;
        }

        public virtual int GetHp() //Returns amont of monster's Hp
        {
            return this.hp;
        }

        public virtual int GetExp() //Returns amont of monsters's Exp
        {
            return this.exp;
        }

        public virtual bool IsDead() // Checks if monster is dead
        {
            if (this.hp < 0)
            {
                dead = true;
            }
            else
            {
                dead = false;
            }
            return this.dead;
        }
    }
}
