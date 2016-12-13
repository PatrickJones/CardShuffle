using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;


namespace CardShuffle.Test
{
    [TestClass]
    public class DeckTest
    {
        List<Card> set = new List<Card>();

        public DeckTest()
        {
            set = Deck.Cards;
        }

        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void DeckHasFiftyTwoCards()
        {
            Assert.AreEqual(52, set.Count);
        }

        [TestMethod]
        public void DeckHasThirteenEachSuit()
        {
            Assert.AreEqual(13, set.Where(s => s.Suit == AppEnums.Suit.Club).Count());
            Assert.AreEqual(13, set.Where(s => s.Suit == AppEnums.Suit.Diamond).Count());
            Assert.AreEqual(13, set.Where(s => s.Suit == AppEnums.Suit.Spade).Count());
            Assert.AreEqual(13, set.Where(s => s.Suit == AppEnums.Suit.Heart).Count());
        }

        [TestMethod]
        public void DeckHasFourEachFaceCards()
        {
            Assert.AreEqual(4, set.Where(s => s.Face == AppEnums.Face.Ace).Count());
            Assert.AreEqual(4, set.Where(s => s.Face == AppEnums.Face.Jack).Count());
            Assert.AreEqual(4, set.Where(s => s.Face == AppEnums.Face.Queen).Count());
            Assert.AreEqual(4, set.Where(s => s.Face == AppEnums.Face.King).Count());
        }

        [TestMethod]
        public void DeckHasThirtySixNumericCards()
        {
            Assert.AreEqual(9, set.Where(s => s.Face == AppEnums.Face.NoFace && s.Suit == AppEnums.Suit.Club).Count());
            Assert.AreEqual(9, set.Where(s => s.Face == AppEnums.Face.NoFace && s.Suit == AppEnums.Suit.Diamond).Count());
            Assert.AreEqual(9, set.Where(s => s.Face == AppEnums.Face.NoFace && s.Suit == AppEnums.Suit.Heart).Count());
            Assert.AreEqual(9, set.Where(s => s.Face == AppEnums.Face.NoFace && s.Suit == AppEnums.Suit.Spade).Count());
        }

        [TestMethod]
        public void DeckIsOrderedBySuit()
        {
            var firstThirteen = set.Take(13);
            var secondThirteen = set.Skip(13).Take(13);
            var thirdThirteen = set.Skip(26).Take(13);
            var finalThirteen = set.Skip(39);

            Assert.IsFalse(firstThirteen.Any(a => a.Suit != firstThirteen.First().Suit));
            Assert.IsFalse(secondThirteen.Any(a => a.Suit != secondThirteen.First().Suit));
            Assert.IsFalse(thirdThirteen.Any(a => a.Suit != thirdThirteen.First().Suit));
            Assert.IsFalse(finalThirteen.Any(a => a.Suit != finalThirteen.First().Suit));
        }
    }
}
