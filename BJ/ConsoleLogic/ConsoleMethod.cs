using BJ.Entities;
using BJ.Helpers;
using BJ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BJ.ConsoleLogic
{
    public class ConsoleMethod
    {
        public void ShowGame()
        {
            new Greeting().DoGreeting();
            UserLogic.user.Name = Console.ReadLine();
            Console.WriteLine("\n" + "So, " + UserLogic.user.Name + ", if you know the rules, we will begin to play, if not, let the developers and they mount a description of them." + Environment.NewLine + "Let's start dealing cards" +  "\n");
            
            while(true)
            {
                new UserLogic().StartGameForUser();
                Thread.Sleep(1000);
                new ComputerLogic().StartGameForComputer();
                Thread.Sleep(1000);
                Console.WriteLine(UserLogic.user.Name + " points = " + UserLogic.userSummPointsFor + "\n" + "Computer points = " + ComputerLogic.compSummPointsFor + "\n");
                new GameResult().GameResults();
                Thread.Sleep(1000);
                Console.WriteLine("Score:" + "\n" + UserLogic.user.Name + ": " + Wins.PlayerQuantityWins + "\n" + ComputerLogic.comp.Name + ": " + Wins.ComputerQuantityWins + "\n"+ "Do you want to continue? Yes - Enter 1, No - Enter 2");
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
            
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
