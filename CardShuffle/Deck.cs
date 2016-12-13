using CardShuffle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    public static class Deck
    {
        public static List<Card> Cards = new List<Card>(52);
        static Deck()
        {
            if (Cards.Count == 0)
            {
                NewDeck();
            }
        }

        public static void NewDeck()
        {
            for (int i = 2; i < 15; i++)
            {
                var cs = new Card
                {
                    Number = (i < 11) ? i : 0,
                    Suit = AppEnums.Suit.Spade,
                    Face = (i > 10) ? (AppEnums.Face)i : AppEnums.Face.NoFace
                };

                var ch = new Card
                {
                    Number = (i < 11) ? i : 0,
                    Suit = AppEnums.Suit.Heart,
                    Face = (i > 10) ? (AppEnums.Face)i : AppEnums.Face.NoFace
                };

                var cd = new Card
                {
                    Number = (i < 11) ? i : 0,
                    Suit = AppEnums.Suit.Diamond,
                    Face = (i > 10) ? (AppEnums.Face)i : AppEnums.Face.NoFace
                };

                var cc = new Card
                {
                    Number = (i < 11) ? i : 0,
                    Suit = AppEnums.Suit.Club,
                    Face = (i > 10) ? (AppEnums.Face)i : AppEnums.Face.NoFace
                };

                Cards.Add(cs);
                Cards.Add(ch);
                Cards.Add(cd);
                Cards.Add(cc);
            }

            Cards = Cards.OrderBy(o => o.Suit).ToList();
        }

        public static List<Card> Shuffle()
        {
            Random r = new Random();
            var nSet = new List<Card>(52);

            while (Cards.Count != 0)
            {
                var rn = r.Next(Cards.Count);
                var elem = Cards.ElementAt(rn);

                nSet.Add(elem);
                Cards.Remove(elem);
            }

            return Cards = nSet;
        }
    }
}
