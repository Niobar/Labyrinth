using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.PlayerCharacters
{
    public static class PlayerCharacter
    {
        public static string Name { get; set; }
        
        public static void PlayerName(string name)
        {
            Name = name;
        }
    }
}
