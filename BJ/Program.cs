using BJ.ConsoleLogic;
using BJ.Entities;
using BJ.Helpers;
using BJ.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BJ
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsoleMethod().ShowGame();
        }
    }
}

//разделить на бизнесс логику и вьюхи
//создать класс консоль
//2-3 строки в методе мейн 
//WorkWithCard workWithCard = new WorkWithCard();

//User user = new User();
//user.Cards = new List<Card>();

//Comp comp = new Comp();
//comp.Cards = new List<Card>();

//new Greeting().DoGreeting();    //Приветствие

//user.Name = Console.ReadLine();
//Console.WriteLine("So, " + user.Name + ", if you know the rules, we will begin to play, if not, let the developers and they mount a description of them." + Environment.NewLine + "Let's start dealing cards" + Environment.NewLine);


//for(;;)
//{
//    int userSummPointsFor = 0;
//    int compSummPointsFor = 0;

//    Юзер
//    for (int i = 0; i < 9; i++)
//    {
//        Console.WriteLine("Your card number: " + (i + 1).ToString());
//        Card c = workWithCard.GetRandomCard();
//        user.Cards.Add(c);
//        Console.WriteLine(user.Cards[i].Suit + " " + user.Cards[i].Sing + " ");
//        userSummPointsFor += user.Cards[i].QuantityPoints;
//        Console.WriteLine("Summ of your points = " + userSummPointsFor + Environment.NewLine);
//        if (userSummPointsFor > 21)
//        {
//            Console.WriteLine("You bust points");
//            break;
//        }
//        Thread.Sleep(2000);
//        bool stop = false;

//        // TODO Добавить проверку на количество очков туза
//        if (userSummPointsFor == 21)
//        {
//            Console.WriteLine();
//            Console.WriteLine("Computer next takes card");
//            break;
//        }
//        if (i >= 1)
//        {
//            Console.WriteLine("Do you want new card? Yes - Enter 1, No - Enter 2");
//            string entry = Console.ReadLine();
//            // TODO Добавить проверку на ввод
//            switch (entry)
//            {
//                case "1":
//                    continue;
//                case "2":
//                    stop = true;
//                    break;
//                default:
//                    break;
//            }
//        }
//        if (stop)
//        {
//            Console.WriteLine();
//            Console.WriteLine("Computer next takes card");
//            break;
//        }
//    }


//    Компьютер
//    for (int i = 0; i < 9; i++)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine();
//        Console.WriteLine("Computer card number: " + (i + 1).ToString());
//        comp.Cards.Add(workWithCard.GetRandomCard());
//        Console.WriteLine("***** " + comp.Cards[i].Suit);
//        compSummPointsFor += comp.Cards[i].QuantityPoints;
//        Console.WriteLine("Summ of computer points = **" + Environment.NewLine);
//        if (compSummPointsFor > 21)
//        {
//            Console.WriteLine("Computer bust points");
//            break;
//        }
//        if (compSummPointsFor < 17)
//        {
//            continue;
//        }
//        else
//        {
//            break;
//        }
//    }


//    Console.WriteLine();
//    Console.WriteLine(user.Name + " points = " + userSummPointsFor);
//    Console.WriteLine("Computer points = " + compSummPointsFor);

//    Результаты
//    if (userSummPointsFor > compSummPointsFor && userSummPointsFor <= 21 && compSummPointsFor <= 21)
//    {
//        Console.WriteLine(user.Name + " win!");
//        user.QuantityOfWins++;
//    }
//    else if (userSummPointsFor == compSummPointsFor && userSummPointsFor <= 21 && compSummPointsFor <= 21)
//    {
//        Console.WriteLine("Draw!");
//    }
//    else if (userSummPointsFor < compSummPointsFor && userSummPointsFor <= 21 && compSummPointsFor <= 21)
//    {
//        Console.WriteLine("Computer win!");
//        comp.QuantityOfWins++;
//    }
//    else if (userSummPointsFor <= 21 && compSummPointsFor > 21)
//    {
//        Console.WriteLine(user.Name + " win!");
//        user.QuantityOfWins++;
//    }
//    else if (userSummPointsFor > 21 && compSummPointsFor <= 21)
//    {
//        Console.WriteLine("Computer win!");
//        comp.QuantityOfWins++;
//    }
//    Console.WriteLine();
//    Console.WriteLine("Score:");
//    Console.WriteLine(user.Name + ": " + user.QuantityOfWins);
//    Console.WriteLine(comp.Name + ": " + comp.QuantityOfWins);
//    Console.WriteLine();

//    //Новая игра
//    Console.WriteLine("Do you want to continue? Yes - Enter 1, No - Enter 2");
//    string entryAnswer = Console.ReadLine();
//    bool stops = false;
//    switch (entryAnswer)
//    {
//        case "1":
//            user.Cards = new List<Card>();
//            comp.Cards = new List<Card>();
//            continue;
//        case "2":
//            stops = true;
//            break;
//    }
//    if (stops)
//        break;
//}

////Окончание
//Console.WriteLine("Finish");
//Console.ReadLine();