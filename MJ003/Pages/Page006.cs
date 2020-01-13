using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    class Page006 : Page
    {
        private string viewDescription = "There are two doors here";
        private string[,] buttonArray = new string[,]
        {
            {"west", "Typical wooden door", "002" },
            {"north", "Dark stone door", "999" }
        };
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override Page Choice(string choice)
        {
            switch (choice)
            {
                case "002":
                    return new Page002();
                case "999":
                    return new Page999();
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
