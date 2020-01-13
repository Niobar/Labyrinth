using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Pages
{
    public abstract class Page
    {
        public abstract string[,] Button();
        public abstract string Description();
        public abstract Page Choice(string choice);
        public abstract string SourcePicture();
        //public abstract bool IsMonsterHere(); //probably won't be using this
    }
}
