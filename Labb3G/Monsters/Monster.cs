namespace Labb3G.Monsters
{
    internal abstract class Monster : IMonster
    {
        private string name;

        private int hp;

        private int exp;

        private int attackDmg;

        internal bool dead;

        public string Name { get => name; set => name = value; }

        public int Hp { get => hp; set => hp = value; }

        public int Exp { get => exp; set => exp = value; }

        public int AttackDmg { get => attackDmg; set => attackDmg = value; }

        public bool Dead { get => dead; set => dead = value; }

        //Runs to attack
        public virtual int Attack() 
        {
            return MyRandomHelper.RandomHelper.RandomNumber(5, attackDmg);
        }

        // Calculates Hp after monster takes damage
        public virtual void TakeDamage(int attack) 
        {
            hp = this.hp - attack;
        }

        //Returns monster's Name
        public virtual string GetName() 
        {
            return this.name;
        }

        //Returns amont of monster's Hp
        public virtual int GetHp() 
        {
            return this.hp;
        }

        //Returns amont of monsters's Exp
        public virtual int GetExp() 
        {
            return this.exp;
        }

        // Checks if monster is dead
        public virtual bool IsDead() 
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
