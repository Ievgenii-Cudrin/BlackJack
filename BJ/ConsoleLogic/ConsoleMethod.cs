using BJ.Entities;
using BJ.Helpers;
using BJ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.ConsoleLogic
{
    public class ConsoleMethod
    {
        public void ShowGame()
        {
            //Приветствие
            new Greeting().DoGreeting();

            UserLogic.user.Name = Console.ReadLine();
            Console.WriteLine("So, " + UserLogic.user.Name + ", if you know the rules, we will begin to play, if not, let the developers and they mount a description of them." + Environment.NewLine + "Let's start dealing cards" + Environment.NewLine);
            
            for (;;)
            {
                //Юзер
                new UserLogic().StartGameForUser();

                //Компьютер
                new ComputerLogic().StartGameForComputer();

                Console.WriteLine();
                Console.WriteLine(UserLogic.user.Name + " points = " + UserLogic.userSummPointsFor);
                Console.WriteLine("Computer points = " + ComputerLogic.compSummPointsFor);

                //Результаты
                new GameResult().GameResults();

                Console.WriteLine();
                Console.WriteLine("Score:");
                Console.WriteLine(UserLogic.user.Name + ": " + Wins.PlayerQuantityWins);
                Console.WriteLine(ComputerLogic.comp.Name + ": " + Wins.ComputerQuantityWins);
                Console.WriteLine();

                //Новая игра
                Console.WriteLine("Do you want to continue? Yes - Enter 1, No - Enter 2");
                string entryAnswer = Console.ReadLine();
                bool stops = false;
                switch (entryAnswer)
                {
                    case "1":
                        UserLogic.user.Cards = new List<Card>();
                        ComputerLogic.comp.Cards = new List<Card>();
                        continue;
                    case "2":
                        stops = true;
                        break;
                }
                if (stops)
                    break;
            }

            //Окончание
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
