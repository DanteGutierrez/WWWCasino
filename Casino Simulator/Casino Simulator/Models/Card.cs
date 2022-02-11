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

        public int GetValFromCard()
        {
            switch (value.ToLower())
            {
                case "ace":
                    return 11;
                case "king":
                    return 10;
                case "queen":
                    return 10;
                case "jack":
                    return 10;
                default:
                    return int.Parse(value);
                
            }
            
        }
        public override string ToString()
        {
            return $"{value} of {suit}";
        }

        
    }
}