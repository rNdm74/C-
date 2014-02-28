using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bridge
{    
    public partial class Bridge : Form
    {
        private Deck deck;
        private Hand[] handArray;

        public Bridge()
        {
            InitializeComponent();            
        }
        
        private void bDeal_Click(object sender, EventArgs e)
        {
            // Clear the display
            lbDisplay.Items.Clear();

            // Make a new deck do be dealt
            deck = new Deck();

            // Deals the four cardinal hands from the deck
            handArray = deck.dealHands();

            // Display the hands
            foreach (Hand hand in handArray)                
                lbDisplay.Items.AddRange(hand.displayHand());            
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the display
                lbDisplay.Items.Clear();

                // Sort hand by HCP
                Array.Sort(handArray);

                // Display the hands
                foreach (Hand hand in handArray)
                    lbDisplay.Items.AddRange(hand.displayHand());
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Please DEAL HANDS before you can SORT BY HCP", "Sort");
            }            
        }
    }

    class Deck
    {
        private List<Card> deck;

        public Deck()
        {
            // Create a new deck
            deck = new List<Card>();

            // Build a new deck
            for (int suit = 0; suit < CONSTANTS.SUIT.Length; suit++)
                for (int rank = 0; rank < CONSTANTS.RANK.Length; rank++)
                    deck.Add(new Card(rank, CONSTANTS.SUIT[suit]));
        }

        public Hand[] dealHands()
        {
            // Return the cardinal hands 
            // When required hands will be dealt from the deck
            // An array of four even randomized hands is then returned 
            return new Hand[]
            {
                dealHand(CONSTANTS.CARDINAL[(int)ECARDINAL.NORTH]),
                dealHand(CONSTANTS.CARDINAL[(int)ECARDINAL.EAST]),
                dealHand(CONSTANTS.CARDINAL[(int)ECARDINAL.SOUTH]),
                dealHand(CONSTANTS.CARDINAL[(int)ECARDINAL.WEST]),
            };
        }

        
        private Hand dealHand(string cardinal)
        {
            // Create a list for the card in a hand
            List<Card> cards = new List<Card>();

            // Used to randomly pick the cards from the deck
            Random rGen = new Random();

            // Work out the hand size
            int handSize = CONSTANTS.DECK_SIZE / CONSTANTS.CARDINAL.Length;

            // Add random cards from the deck
            for (int card = 0; card < handSize; card++)
            {
                // Pick a random card
                int randomCard = rGen.Next(deck.Count);

                // Add the random card to the hand
                cards.Add(deck.ElementAt(randomCard));

                // Remove the picked card from the deck
                deck.RemoveAt(randomCard);
            }

            // Return the hand
            return new Hand(cardinal, cards);
        }
    }
        
    class Card
    {
        private int rank;
        private string suit;
        private int value;

        public Card(int rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
            this.value = getValueFromRank(rank);
        }
            
        // Gets
        public int getRank()        { return rank; }
        public string getSuit()     { return suit; }
        public int getValue()       { return value; }
        
        private int getValueFromRank(int cardRank) 
        {
            // If card is Jack, Queen, King, Ace 
            // return its value else return nothing
            switch (cardRank)
            {
                case 9: return 1;
                case 10: return 2;
                case 11: return 3;
                case 12: return 4;
                default: return 0;
            }
        }        
    }

    class Hand : IComparable
    {
        private string cardinal;
        private List<Card> cards;
        private int highCardPoints;

        public Hand(string cardinal, List<Card> cards)
        {
            this.cardinal = cardinal;
            this.cards = cards;
            this.highCardPoints = 0;
    
            // Populates high card points of the hand
            calculateHCP();

            // Sorts the hand by suit
            sortIntoSuits();
        }

        public int getHCP()
        {
            return highCardPoints; 
        }

        private void calculateHCP()
        {
            // Adds all the values from the cards in the hand 
            foreach (Card card in cards) highCardPoints += card.getValue();
        }

        private void sortIntoSuits()
        {
            // Sort the cards in the hand based on rank
            cards.Sort(new SortOnRank());
        }

        public string[] displayHand()
        {
            // Returns a string array in the appropriate bridge format
            List<string> hand = new List<string>();

            // Build the string that is displayed                              EXAMPLE
            hand.Add("**************************");                 // **************************
            hand.Add(cardinal + ":");                               // North:
                                                                    // S:       ####
            foreach (string suit in CONSTANTS.SUIT)                 // H:       ####
                hand.Add(suit + ":\t" + getSuitCards(suit));        // D:       ####
                                                                    // C:       ####                                                                    
            hand.Add("HCP:\t" + highCardPoints.ToString());         // HCP:     ####        
            hand.Add("");                                           //                            

            return hand.ToArray();
        }
                
        private string getSuitCards(string suit)
        {
            string ranks = "";

            // Builds a string of the card ranks based on the passed in suit
            foreach (Card card in cards)
                if(suit.Equals(card.getSuit()))
                    ranks += CONSTANTS.RANK[card.getRank()];

            return ranks;            
        }

        public int CompareTo(Object obj)
        {
            Hand a = this;
            Hand b = obj as Hand;

            if (a.getHCP() < b.getHCP()) return 1;
            else if (a.getHCP() > b.getHCP()) return -1;
            else return 0;
        }

        // Used to sort the cards based on rank
        private class SortOnRank : IComparer<Card>
        {
            public int Compare(Card a, Card b)
            {
                if (a.getRank() < b.getRank()) return 1;
                else if (a.getRank() > b.getRank()) return -1;
                else return 0;
            }
        }
    }

    enum ECARDINAL
    {
        NORTH = 0, EAST = 1, SOUTH = 2, WEST = 3
    }

    static class CONSTANTS
    {
        // Change if you would like to modify the labels that are displayed to the form
        // NOTE: To change format of the hands displayed, modify displayHand() in Hand class
        public static readonly string[] RANK = { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
        public static readonly string[] SUIT = { "S", "H", "D", "C" };  // SPADES, HEARTS, DIAMONDS, CLUBS
        public static readonly string[] CARDINAL = { "North", "East", "South", "West" };

        // Change this to play with a smaller or larger deck 
        // NOTE: DECK_SIZE must be even
        public const int DECK_SIZE = 52;        
    }
}

