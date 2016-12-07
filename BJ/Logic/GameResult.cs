using BJ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Logic
{
    public class GameResult
    {
        public void GameResults()
        {
            if (UserLogic.userSummPointsFor > ComputerLogic.compSummPointsFor && UserLogic.userSummPointsFor <= 21 && ComputerLogic.compSummPointsFor <= 21)
            {
                Console.WriteLine(UserLogic.user.Name + " win!");
                Wins.PlayerQuantityWins++;
            }
            else if (UserLogic.userSummPointsFor == ComputerLogic.compSummPointsFor && UserLogic.userSummPointsFor <= 21 && ComputerLogic.compSummPointsFor <= 21)
            {
                Console.WriteLine("Draw!");
            }
            else if (UserLogic.userSummPointsFor < ComputerLogic.compSummPointsFor && UserLogic.userSummPointsFor <= 21 && ComputerLogic.compSummPointsFor <= 21)
            {
                Console.WriteLine("Computer win!");
                Wins.ComputerQuantityWins++;
            }
            else if (UserLogic.userSummPointsFor <= 21 && ComputerLogic.compSummPointsFor > 21)
            {
                Console.WriteLine(UserLogic.user.Name + " win!");
                Wins.PlayerQuantityWins++;
            }
            else if (UserLogic.userSummPointsFor > 21 && ComputerLogic.compSummPointsFor <= 21)
            {
                Console.WriteLine("Computer win!");
                Wins.ComputerQuantityWins++;
            }
        }
    }
}
