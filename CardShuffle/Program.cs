using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardShuffle.AppEnums;

namespace CardShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOrderedDeck();
            ShuffleDeck();
        }

        // returns ordered deck of cards based on suit
        private static void GetOrderedDeck()
        {
            foreach (var card in Deck.Cards)
            {
                Console.WriteLine(card.Name);
            }

            Console.ReadLine();
        }

        // returns a shuffled deck of cards
        private static void ShuffleDeck()
        {
            Deck.Shuffle();

            foreach (var card in Deck.Cards)
            {
                Console.WriteLine(card.Name);
            }

            Console.ReadLine();
        }
    }
}
