using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace Casino_Simulator.Models
{
    public class Card
    {

        public Suit suit { get; set; }
        public string value { get; set; }

        public Card(Suit suit, string value)
        {
            this.suit = suit;
            this.value = value;
        }
        
        public override string ToString()
        {
            return $"{value} of {suit}";
        }

        
    }
}