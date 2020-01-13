using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003
{
    public static class GlobalVariables
    {
        public static bool lost = false; 
        public static bool win = false;
        public static Random randomizer = new Random();

        public static CharacterWindow playerCharacterWindow = new CharacterWindow();

        public static void WinGame()
        {
            win = true;
            playerCharacterWindow.Close();
            var window = new WinGame();
        }

    }
}
