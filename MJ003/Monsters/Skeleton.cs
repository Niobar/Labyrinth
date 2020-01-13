using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ003.Monsters
{
    public class Skeleton : Monster
    {
        private string imageSource = "Monsters/img/skeleton.png";

        public override string ImageSource()
        {
            return imageSource;
        }
    }
}
