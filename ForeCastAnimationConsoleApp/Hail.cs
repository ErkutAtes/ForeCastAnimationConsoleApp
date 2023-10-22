using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ForeCastAnimationConsoleApp
{
    internal class Hail : WheatherEvents
    {
        public Hail()
        {
            this.WheaterType = "o";
        }

        public override string ConsoleMessage()
        {
            return "                                        Oops, this is gonna hurt";
        }

    }
}
