using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{

    class Page999 : Page
    {
        private string viewDescription = "Congratulations you've made it to the end. You survived Labirynt";
        private string[,] buttonArray = new string[,]
        {
            {"Exit", "This is the end of your journey", "999" }
        };
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override Page Choice(string choice)
        {
            GlobalVariables.WinGame();
            switch (choice)
            {
                case "999":
                    return new Page999();
            }
            return new Page000();
        }

        public override string Description()
        {
            return viewDescription;
        }
        private string sourceImage = "pack://application:,,,/Pages/img/dungeonExit.jpg";
        public override string SourcePicture()
        {
            return sourceImage;
        }
    }
}
