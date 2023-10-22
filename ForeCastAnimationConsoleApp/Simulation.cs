using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForeCastAnimationConsoleApp
{
    internal class Simulation
    {

        private List<string> wheatherPattern = new List<string>(10);


        public Simulation()
        {
            //List initilization
            for (int i = 0; i < 100; i++) 
                wheatherPattern.Add(" ");
        }

        
        


        public void MainSeqStart() 
        {
            int randomValue = new Random().Next(1,4);
            
            switch (randomValue) 
            { 
                case 1:
                    SimulateStart(new Rain());
                break;

                case 2:
                    SimulateStart(new Snow());
                break;

                case 3:
                    SimulateStart(new Hail());
                break;

                default:
                    Environment.Exit(0);
                break;
            }
        }
        private void SimulateStart(WheatherEvents wheatherEvent) 
        {
            //Consle print massage and type of wheather event
            Console.WriteLine(wheatherEvent.ConsoleMessage());
            Console.WriteLine();



            for (int i = 0; i < Console.BufferHeight + 10 ; i++) 
            {
                //10 haneli list içine random value yerlere işaret atıcam
                RandomValues(wheatherEvent);

                //Pattern print
                foreach (var item in wheatherPattern)
                {
                    Console.Write(item);
                }

                //Reset list
                RandomValuesReset();
                //For new line
                Console.WriteLine();

                //For Delay
                Thread.Sleep(600);
                    
            }

        }

        private List<string> RandomValues(WheatherEvents wheatherEvents) 
        {
            Random rnd = new Random();

            //15 tane item atıyorum içine
            for (int i = 0; i < 35; i++) 
            {
                int tempValue = rnd.Next(0,100);
                //Alan boş ise          
                if (wheatherPattern[tempValue] == " ") 
                {
                    wheatherPattern[tempValue] = wheatherEvents.WheaterType;
                }

            }
            return wheatherPattern;
        }


        private void RandomValuesReset()
        {
            for (int j = 0; j < 100; j++)
            {
                wheatherPattern[j] = " ";
            }

        }






    }
}
