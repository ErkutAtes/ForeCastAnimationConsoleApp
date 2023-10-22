using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeCastAnimationConsoleApp
{
    internal class WheatherEvents
    {

        public  string WheaterType { get; set; }


        public virtual string Do() 
        {
            //For Override
            return "";
        }

        public virtual string ConsoleMessage()
        {
            return "";
            //For override
        }

 
    }
}
