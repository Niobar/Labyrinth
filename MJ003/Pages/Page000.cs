using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    class Page000 : Page
    {
        private string[,] buttonArray = new string[,]
        {
            {"it's a trap!", "yup it's bad", "dead" }
        };
        private string viewDescription = "I don't know how you got here, but you're going to die here";
        public override string[,] Button()
        {
            return buttonArray;
        }

        public override Page Choice(string choice)
        {
            GlobalVariables.lost = true;
            return new Page000();//need to change it with window closing in only first button click
        }

        public override string Description()
        {
            return viewDescription;
        }
        private string sourceImage = "pack://application:,,,/Pages/img/cellar.jpg";
        public override string SourcePicture()
        {
            return sourceImage;
        }
    }
}
