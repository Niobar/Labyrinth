using MJ003.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003
{
    public static class MonsterPresence
    {
        public static Dictionary<string, MonsterLedger> monstersLedger = new Dictionary<string, MonsterLedger>
        {
            {"003", new MonsterLedger( true, new Skeleton() ) }
        };
        //public static Dictionary<string, bool> monstersLedger = new Dictionary<string, bool>
        //{
        //    {"003", true}
        //};
    }
}
