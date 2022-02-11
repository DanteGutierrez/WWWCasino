using System;
using System.Collections.Generic;
using System.Linq;

namespace Casino_Simulator.Models
{
    public class Deck
    {
        private List<Card> lstDeck = new List<Card>();
        private List<Card> lstDiscard = new List<Card>();
        private string[] arrValues = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
        private Suit[] arrSuits = {Suit.Hearts, Suit.Diamonds, Suit.Spades, Suit.Clubs};

        public Deck() //constructor
        {
            CreateDeck();
            ShuffleDeck();
        }

        private void CreateDeck()
        {
            foreach (Suit suit in arrSuits)
            {
                foreach (string value in arrValues)
                {
                    lstDeck.Add(new Card(suit, value));
                }
            }
        }

        public List<Card> DealMultipleCards(int cardCount)
        {
            List<Card> lstCards = new List<Card>();
            for (int i = 0; i < cardCount; i++)
            {
                lstCards.Add(DealCard());
            }

            return lstCards;
        }
        
        public Card DealCard()
        {
            //check if lstDeck.Count = 0
            if (LstDeck.Count.Equals(0))
            {
                ShuffleDeck();
            }
            Card card = lstDeck[0];
            lstDiscard.Add(lstDeck[0]);
            lstDeck.RemoveAt(0);
            return card;
        }
        
        //leave this here just in case
        public int GetValFromCard(Card card)
        {
            switch (card.value.ToLower())
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
                    return int.Parse(card.value);
                
            }
        }

        public void ShuffleDeck()
        {
            this.lstDeck = lstDeck.Concat(lstDiscard).ToList();
            lstDiscard.Clear();
            var rnd = new Random();
            //have this look 2-5 times
            for (int loopCount = 0; loopCount <= rnd.Next(2, 5); loopCount++)
            {
                for (int i = 0; i < lstDeck.Count; i++)
                {
                    int grabItem = rnd.Next(0,lstDeck.Count-1);
                    var temp = lstDeck[grabItem];
                    lstDeck[i] = lstDeck[grabItem];
                    lstDeck[grabItem] = temp;
                } 
            }
        }

        public List<Card> LstDeck
        {
            get => lstDeck;
            set => lstDeck = value;
        }

        public List<Card> LstDiscard
        {
            get => lstDiscard;
            set => lstDiscard = value;
        }
    }
}

// -iterate through an array of suit
//     -add 1-9 of that card of that suit
//     -iterate through the face cards and suit
//     -add each to deck
//     -card[52] arrDeck - initialize full
//     -card[52] arrDiscard - initialize empty
//     -method to shuffle deck	