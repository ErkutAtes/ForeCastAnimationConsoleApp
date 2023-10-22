using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeCastAnimationConsoleApp
{
    internal class Rain : WheatherEvents
    {
        public Rain()
        {
            this.WheaterType = "'";
        }

        public override string ConsoleMessage()
        {
            return "                                         Yesss, it's gonna start raining.";
        }
    }
}
