using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeCastAnimationConsoleApp
{
    internal class Snow : WheatherEvents
    {
        public Snow()
        {
            this.WheaterType = "*";
        }
       

        public override string ConsoleMessage()
        {
            return "                              Yesssss, it's gonna start snowing";
        }
    }
}
