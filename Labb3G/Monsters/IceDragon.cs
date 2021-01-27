namespace Labb3G.Monsters
{
    using System;

    internal class IceDragon : Monster
    {
        public IceDragon() // Constructor
        {
            base.Name = "Ice Dragon";
            base.Hp = 70;
            base.Exp = 80;
            base.AttackDmg = 10;
        }

        // runs the attack
        public override int Attack() 
        {
            Console.WriteLine("ice dragon attack!");
            return base.Attack();
        }

        //Returns amont of monsters's Exp
        public override int GetExp() 
        {
            return base.GetExp();
        }

        //Returns amont of monster's Hp
        public override int GetHp() 
        {
            return base.GetHp();
        }

        // Checks if monster is dead
        public override bool IsDead() 
        {
            return base.IsDead();
        }

        //Returns monster's Name
        public override string GetName() 
        {
            return base.GetName();
        }

        // Calculates Hp after monster takes damage
        public override void TakeDamage(int attack) 
        {
            base.TakeDamage(attack);
        }
    }
}
