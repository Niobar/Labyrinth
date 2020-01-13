using MJ003.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003
{
    public struct MonsterLedger
    {
        public bool undefeated;
        public Monster monster;

        public MonsterLedger(bool x, Monster y)
        {
            undefeated = x;
            monster = y;
        }
    }
}
