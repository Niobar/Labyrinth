using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    class Page003 : Page
    {
        private string viewDescription = "room with two doors";
        public string[,] buttonArray = {
            { "south", "11111", "001" },
            {"east", "22222", "005" },
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
                case "005":
                    return new Page005();
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
