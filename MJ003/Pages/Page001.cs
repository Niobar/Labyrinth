using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    public class Page001 : Page
    {
        private string[,] buttonArray = {
            {"east", "1", "002" },
            {"north", "2", "003" },
            {"west", "3", "004" }
        };
        private string viewDescription = "You see three doors. Choose one";

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
                case "002":
                    return new Page002();

                case "003":
                    return new Page003();

                case "004":
                    return new Page004();
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
