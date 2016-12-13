using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CardShuffle.AppEnums;

namespace CardShuffle
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Number { get; set; }

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
