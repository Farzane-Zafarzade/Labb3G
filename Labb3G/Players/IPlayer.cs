using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3G.Players
{
    interface IPlayer
    {
        string name { get; set; }
        int Attack();
        int TakeDamage(int attack);
        void PrintInfo();
        int GainExp(int monstersExp);
        string GetName();
        int GetHp();
        int GetExp();
        int GetLevel();
        bool IsDead();
        void LevelUp();

    }
}
