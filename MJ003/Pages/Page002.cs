using MJ003.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    public class Page002 : Page
    {
        private string viewDescription = "You walk through a corridor until you find junction.";
        public string[,] buttonArray = {
            { "north", "room", "005" },
            {"east", "unknown", "006" },
            {"west", "need to change description or choose with direction of entry", "001" }
                    };
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override string Description()
        {
            return viewDescription;
        }

        public override Page Choice(string choice)
        {
            switch (choice)
            {
                case "005":
                    return new Page005();
                case "006":
                    return new Page006();
                case "001":
                    return new Page001();
            }
            return new Page000();
        }
        private string sourceImage = "pack://application:,,,/Pages/img/dark.jpg";
        public override string SourcePicture()
        {
            return sourceImage;
        }

    }
}
