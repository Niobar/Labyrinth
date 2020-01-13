using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003
{
    public static class CombatTurn
    {
        private static int D6()
        {
            return GlobalVariables.randomizer.Next(1, 7);
        }
        public static int[] BeginningTurn()
        {
            return new int[]
            {
                D6(), D6(), D6(), D6(), D6()
            };
        }
    }
}
