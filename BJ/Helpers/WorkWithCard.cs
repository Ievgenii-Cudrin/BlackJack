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

        public List<Card> DeckFill()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Sing sing in Enum.GetValues(typeof(Sing)))
                {
                    int points = sing.ToString() == "Two" ? 2 : sing.ToString() == "Three" ? 3 : sing.ToString() == "Four" ? 4 : sing.ToString() == "Five" ? 5 : sing.ToString() == "Six" ? 6 : sing.ToString() == "Seven" ? 7 : sing.ToString() == "Eight" ? 8 : sing.ToString() == "Nine" ? 9 : sing.ToString() == "Ace" ? 11 : 10;
                    Card card = new Card() { QuantityPoints = points, Sing = sing, Suit = suit };
                    cards.Add(card);
                }
            }
            return cards;
        }
        
        public Card GetRandomCard()
        {
            List<Card> randomizedList = new List<Card>();
            Random rnd = new Random();
            List<Card> deckFill = DeckFill();
            while (deckFill.Count > 0)
            {
                int indexForRandomize = rnd.Next(0, deckFill.Count);
                randomizedList.Add(deckFill[indexForRandomize]);
                deckFill.RemoveAt(indexForRandomize);
            }
            int indexForCard = new Random().Next(deckFill.Count);
            Card card = randomizedList[indexForCard];
            randomizedList.Remove(card);
            return card;
        }
    }
}
