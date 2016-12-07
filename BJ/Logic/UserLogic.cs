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
            user.Name = Console.ReadLine();
            Console.WriteLine("So, " + user.Name + ", if you know the rules, we will begin to play, if not, let the developers and they mount a description of them." + Environment.NewLine + "Let's start dealing cards" + Environment.NewLine);
            
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Your card number: " + (i + 1).ToString());
                user.Cards.Add(workWithCard.GetRandomCard());
                Console.WriteLine(user.Cards[i].Suit + " " + user.Cards[i].Sing + " ");
                userSummPointsFor += user.Cards[i].QuantityPoints;
                Console.WriteLine("Summ of your points = " + userSummPointsFor + Environment.NewLine);
                bool stop = false;
                if (userSummPointsFor > 21)
                {
                    Console.WriteLine("You bust points");
                    break;
                }
                // TODO Добавить проверку на количество очков туза
                else if (userSummPointsFor == 21)
                {
                    Console.WriteLine();
                    Console.WriteLine("Computer next takes card");
                    break;
                }
                if (i >= 1)
                {
                    Console.WriteLine("Do you want new card? Yes - Enter 1, No - Enter 2");
                    string entry = Console.ReadLine();
                    // TODO Добавить проверку на ввод
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
                    Console.WriteLine();
                    Console.WriteLine("Computer next takes card");
                    break;
                }
            }
        }
    }
}
