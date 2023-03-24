using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_1
{
    internal class Animals
    {
        public string razza { get; set; }
        public int eta { get; set; }
        public string color { get; set; }

        public void startVoice()
        {

            Console.WriteLine(this.razza + " di colore " 
                + this.color 
                + " fa il verso");

        }

        public void startEat()
        {

            Console.WriteLine(this.razza + " di colore "
                + this.color
                + " sta Mangiando"
                );
        }
    }
}
