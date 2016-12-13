using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardShuffle.AppEnums;

namespace CardShuffle
{
    /// <summary>
    /// Card object
    /// </summary>
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Number { get; set; }

        /// <summary>
        /// Gets the name of the Card (i.e. 2 of Spades).
        /// </summary>
        public string Name
        {
            get
            {
                string val = (Number == 0) ? Enum.GetName(typeof(Face), Face) : Number.ToString();
                return $"{val} of {Enum.GetName(typeof(Suit), Suit)}";
            }
        }

    }
}
