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
    public class UserLogic
    {
        public static User user = new User();
        WorkWithCard workWithCard = new WorkWithCard();
        public static int userSummPointsFor = 0;
        public void StartGameForUser()
        {
            user.Cards = new List<Card>();
            for (int i = 0; i < 9; i++)
            {
                Thread.Sleep(1000);
                user.Cards.Add(workWithCard.GetRandomCard());      //take card and plus summ pionts 
                userSummPointsFor += user.Cards[i].QuantityPoints;
                Console.WriteLine("Your card number: " + (i + 1).ToString() + "\n" + user.Cards[i].Suit + " " + user.Cards[i].Sing + " " + "\n" + "Summ of your points = " + userSummPointsFor + Environment.NewLine);
                bool stop = false;
                if (userSummPointsFor > 21)
                {
                    Console.WriteLine("You bust points");
                    break;
                }
                else if (userSummPointsFor == 21)
                {
                    Console.WriteLine("\n" + "Computer next takes card");
                    break;
                }
                if (i >= 1)
                {
                    Console.WriteLine("Do you want new card? Yes - Enter 1, No - Enter 2");
                    string entry = Console.ReadLine();
                    switch (entry)
                    {
                        case "1":
                            continue;
                        case "2":
                            stop = true;
                            break;
                        default:
                            break;
                    }
                }
                if (stop)
                {
                    Console.WriteLine("\n" + "Computer next takes card");
                    break;
                }
            }
        }
    }
}
