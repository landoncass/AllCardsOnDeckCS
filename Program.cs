using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<string>() { };
            for (var suitValue = 0; suitValue < 4; suitValue++)
            {
                string suit = "Suit Name";
                if (suitValue == 0)
                {
                    suit = "Spades";
                }
                else if (suitValue == 1)
                {
                    suit = "Clubs";
                }
                else if (suitValue == 2)
                {
                    suit = "Diamonds";
                }
                else if (suitValue == 3)
                {
                    suit = "Hearts";
                }
                for (var cardNumber = 0; cardNumber < 14; cardNumber++)
                {
                    if (cardNumber == 0)
                    {
                        deck.Add($"Ace of {suit}");
                    }
                    else if (cardNumber == 2)
                    {
                        deck.Add($"Two of {suit}");
                    }
                    else if (cardNumber == 3)
                    {
                        deck.Add($"Three of {suit}");
                    }
                    else if (cardNumber == 4)
                    {
                        deck.Add($"Four of {suit}");
                    }
                    else if (cardNumber == 5)
                    {
                        deck.Add($"Five of {suit}");
                    }
                    else if (cardNumber == 6)
                    {
                        deck.Add($"Six of {suit}");
                    }
                    else if (cardNumber == 7)
                    {
                        deck.Add($"Seven of {suit}");
                    }
                    else if (cardNumber == 8)
                    {
                        deck.Add($"Eight of {suit}");
                    }
                    else if (cardNumber == 9)
                    {
                        deck.Add($"Nine of {suit}");
                    }
                    else if (cardNumber == 10)
                    {
                        deck.Add($"Ten of {suit}");
                    }
                    else if (cardNumber == 11)
                    {
                        deck.Add($"Jack of {suit}");
                    }
                    else if (cardNumber == 12)
                    {
                        deck.Add($"Queen of {suit}");
                    }
                    else if (cardNumber == 13)
                    {
                        deck.Add($"King of {suit}");
                    }
                }

            }
            for (var i = 0; i < 52; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }
    }
}

