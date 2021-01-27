namespace Labb3G.Monsters
{
    using System;

    internal class DarkDragon : Monster
    {
        public DarkDragon()  // Constructor
        {
            base.Name = "Dark Dragon";
            base.Hp = 120;
            base.Exp = 100;
            base.AttackDmg = 40;
        }

        // Runs the attack
        public override int Attack() 
        {
            Console.WriteLine("Dark dragon attack!");
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
