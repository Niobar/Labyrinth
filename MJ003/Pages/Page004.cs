using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    class Page004 : Page
    {
        private string viewDescription = "room with two doors";
        public string[,] buttonArray = {
            { "east", "11111", "001" }
                                        };
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override Page Choice(string choice)
        {
            switch (choice)
            {
                case "001":
                return new Page001();
            }
            return new Page000();
        }

        public override string Description()
        {
        return viewDescription;
        }
        private string sourceImage = "pack://application:,,,/Pages/img/dark.jpg";
        public override string SourcePicture()
        {
            return sourceImage;
        }
    }
}
