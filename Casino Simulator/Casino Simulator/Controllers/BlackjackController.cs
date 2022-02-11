using System.Collections.Generic;
using Casino_Simulator.Models;

namespace Casino_Simulator.Controllers
{
    public class BlackjackController
    {
        private List<Card> lstUserHand = new List<Card>();
        private List<Card> lstDealerHand = new List<Card>();
        private Deck blackJackDeck = new Deck();

        public BlackjackController()
        {
            //creates an instance of deck within here
            this.lstUserHand = DealHand(blackJackDeck);
            this.lstDealerHand = DealHand(blackJackDeck);
        }
        
        private List<Card> DealHand(Deck deck)
        {
            return deck.DealMultipleCards(2);
        }

        public int GetValueOfHand(List<Card> lstHand) //pass in the hand of cards, returns the total value of said cards
        {//gotta fucking check for ace=1 or ace=11
            int intHandValue = 0;
            int numAces = 0;
            foreach (Card card in lstHand)
            {
                intHandValue += card.GetValFromCard();
                if (card.value.ToLower().Equals("ace")) numAces++;
            }

            if (numAces > 0 && intHandValue > 21) //if they have more than 21 and have aces, they will be set to 1
            {
                for (int i = 0; i <= numAces; i++)
                {
                    if (intHandValue > 21)
                    {
                        intHandValue -= 10;
                    }
                }
            }
            return intHandValue;
        }

        public List<Card> LstUserHand => lstUserHand;

        public List<Card> LstDealerHand => lstDealerHand;

        public Deck BlackJackDeck => blackJackDeck;
    }
}