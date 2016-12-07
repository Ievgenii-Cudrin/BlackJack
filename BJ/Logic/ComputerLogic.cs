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
                comp.Cards.Add(workWithCard.GetRandomCard());
                compSummPointsFor += comp.Cards[i].QuantityPoints;
                Console.WriteLine("\n" + "Computer card number: " + (i + 1).ToString() + "\n" + "***** " + comp.Cards[i].Suit + "\n" + "Summ of computer points = **" + "\n");
                if (compSummPointsFor >= 17)
                    break;
                else
                    continue;
            }
        }
    }
}
