using BJ.Entities;
using BJ.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BJ.Logic
{
    public class ComputerLogic
    {
        WorkWithCard workWithCard = new WorkWithCard();
        public static Comp comp = new Comp();

        public static int compSummPointsFor = 0;

        public void StartGameForComputer()
        {
            comp.Cards = new List<Card>();
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("Computer card number: " + (i + 1).ToString());
                comp.Cards.Add(workWithCard.GetRandomCard());
                Console.WriteLine("***** " + comp.Cards[i].Suit);
                compSummPointsFor += comp.Cards[i].QuantityPoints;
                Console.WriteLine("Summ of computer points = **" + Environment.NewLine);
                if (compSummPointsFor > 21)
                {
                    Console.WriteLine("Computer bust points");
                    break;
                }
                if (compSummPointsFor < 17)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
