using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is how you create a deck of cards
            var deck = new List<string>() { };
            for (var suitValue = 4 - 1; suitValue >= 0; suitValue--)
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
            //Here is how we shuffle the deck
            var numberOfCards = deck.Count;
            for (var rightIndex = numberOfCards - 1; rightIndex > 0; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }
            //Drawing cards from the deck and displaying the top two cards
            var card1 = deck[0];
            var card2 = deck[1];
            var card3 = deck[2];
            var card4 = deck[3];

            Console.WriteLine(card1);
            Console.WriteLine(card2);

            //Creating two hands of two different cards and displaying what each hand is
            var playerHand = new List<string>() { card1, card2 };
            Console.WriteLine($"In my hand I have a {playerHand[0]} and a {playerHand[1]}");
            var playerHand2 = new List<string>() { card3, card4 };
            Console.WriteLine($"My second hand has a {playerHand2[0]} and a {playerHand2[1]}");
        }
    }
}

