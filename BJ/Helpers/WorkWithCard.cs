using BJ.Entities;
using BJ.TypesEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ.Helpers
{
    public class WorkWithCard
    {
        List<Card> cards = new List<Card>();
        List<Card> GetCards()
        {
            int points = 0;

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Sing sing in Enum.GetValues(typeof(Sing)))
                {   
                    switch (sing.ToString())
                    {
                        case "Two":
                            points = 2;
                            break;
                        case "Three":
                            points = 3;
                            break;
                        case "Four":
                            points = 4;
                            break;
                        case "Five":
                            points = 5;
                            break;
                        case "Six":
                            points = 6;
                            break;
                        case "Seven":
                            points = 7;
                            break;
                        case "Eight":
                            points = 8;
                            break;
                        case "Nine":
                            points = 9;
                            break;
                        case "Ten":
                        case "Valet":
                        case "Dama":
                        case "Korol":
                            points = 10;
                            break;
                        case "Tuz":
                            points = 11;
                            break;
                        default:
                            break;
                    }
                    Card card = new Card() {
                        QuantityPoints = points,
                        Sing = sing,
                        Suit = suit
                    };
                    cards.Add(card);
                }
            }
            return cards;
        }

        public Card GetRandomCard()
        {
            List<Card> cards = GetCards();
            List<Card> newCards = Randomize(cards);
            int index = new Random().Next(newCards.Count);
            return newCards[index];
        }
        public static List<Card> Randomize(List<Card> list)
        {
            List<Card> randomizedList = new List<Card>();
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count); //pick a random item from the master list
                randomizedList.Add(list[index]); //place it at the end of the randomized list
                list.RemoveAt(index);
            }
            return randomizedList;
        }

    }
}
