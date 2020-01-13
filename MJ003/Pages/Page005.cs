using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    class Page005 : Page
    {
        private string viewDescription = "room with two doors";
        public string[,] buttonArray = {
            { "west", "Bewere of monsters", "003" },
            {"south", "002", "002" },
                    };
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override Page Choice(string choice)
        {
            switch (choice)
            {
                case "003":
                    return new Page003();
                case "002":
                    return new Page002();
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
