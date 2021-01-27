using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.Monsters
{
    interface IMonster
    {
        int  Attack();
        void TakeDamage(int dmg);
        string GetName();
        int GetHp();
        int GetExp();
        bool IsDead();
    }
}
