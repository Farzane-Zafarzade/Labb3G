using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.Monsters
{
    class FireDragon:Monster
    {
        public FireDragon() // Constructor
        {
            base.Name = "Fire Dragon";
            base.Hp = 90;
            base.Exp = 90;
            base.AttackDmg = 25;
        }


        public override int Attack() // Runs to attack
        {
            Console.WriteLine("Firedragon attack!");
            return base.Attack();
        }

        public override int GetExp() //Returns amont of monsters's Exp
        {
            return base.GetExp();
        }

        public override int GetHp() //Returns amont of monster's Hp
        {
            return base.GetHp();
        }

        public override bool IsDead() // Checks if monster is dead
        {
            return base.IsDead();
        }

        public override string GetName() //Returns monster's Name
        {
            return base.GetName();
        }

        public override void TakeDamage(int attack) // Calculates Hp after monster takes damage
        {
            base.TakeDamage(attack);
        }

    }
}
