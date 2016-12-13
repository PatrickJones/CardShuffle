using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CardShuffle.Test
{
    /// <summary>
    /// Summary description for ShuffleTest
    /// </summary>
    [TestClass]
    public class ShuffleTest
    {
        [TestMethod]
        public void VerifyCardIsRemovedFromOrderedDeck()
        {
            Random r = new Random();
            var nSet = new List<Card>();

            var rn = r.Next(Deck.Cards.Count);
            var elem = Deck.Cards.ElementAt(rn);

            nSet.Add(elem);
            Deck.Cards.Remove(elem);


            Assert.IsFalse(Deck.Cards.Contains(elem));
            Assert.IsTrue(nSet.Contains(elem));
        }

        [TestMethod]
        public void VerifyDeckIsShuffled()
        {
            Deck.Shuffle();
            var shuffle1 = Deck.Cards;

            var firstThirteen = shuffle1.Take(13);
            var secondThirteen = shuffle1.Skip(13).Take(13);
            var thirdThirteen = shuffle1.Skip(26).Take(13);
            var finalThirteen = shuffle1.Skip(39);

            Assert.IsTrue(firstThirteen.Any(a => a.Suit != firstThirteen.First().Suit));
            Assert.IsTrue(secondThirteen.Any(a => a.Suit != secondThirteen.First().Suit));
            Assert.IsTrue(thirdThirteen.Any(a => a.Suit != thirdThirteen.First().Suit));
            Assert.IsTrue(finalThirteen.Any(a => a.Suit != finalThirteen.First().Suit));
        }
    }
}
