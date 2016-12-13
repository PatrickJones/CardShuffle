using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle
{
    public class AppEnums
    {
        public enum Face
        {
            NoFace = 0,
            Jack = 11,
            Queen = 12,
            King = 13,
            Ace = 14
        }

        public enum Suit
        {
            Spade = 1,
            Heart = 2,
            Diamond = 3,
            Club = 4
        }
    }
}
