using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BJ.Helpers
{
    public class Greeting
    {
        public void DoGreeting()
        {
            //Thread.Sleep(1000);
            Console.WriteLine("Hello. Do you want to play blackjack with computer?" + Environment.NewLine);
            //Thread.Sleep(3000);
            Console.WriteLine("Lets do it!" + Environment.NewLine);
            //Thread.Sleep(2000);
            Console.Write("To get started, please, enter your name: ");
        }
    }
}
