using System;
using System.Collections.Generic;

//Problem: https://projecteuler.net/problem=54

namespace ProjectEuler
{
    public class Problem54
    {
        public int Winner(string[] hand)
        {
            Card[] player1 = new Card[5];
            Card[] player2 = new Card[5];

            for (int i = 0; i < 5; i++)
            {
                player1[i] = new Card(hand[i][0], hand[i][1]);
                player2[i] = new Card(hand[i + 5][0], hand[i + 5][1]);
            }

            if(GetHandRank(player1) > GetHandRank(player2))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        int GetHandRank(Card[] cards)
        {
            Dictionary<int, int> valueOccurence = new Dictionary<int, int>();
            Dictionary<char, int> suitOccurence = new Dictionary<char, int>();

            int highest = 0;

            //Get value and suit occurences
            foreach(Card card in cards)
            {
                if (!valueOccurence.ContainsKey(card.value))
                {
                    valueOccurence.Add(card.value, 1);
                }
                else
                {
                    valueOccurence[card.value]++;
                }

                if(card.value > highest)
                {
                    highest = card.value;
                }

                if (!suitOccurence.ContainsKey(card.suit))
                {
                    suitOccurence.Add(card.suit, 1);
                }
                else
                {
                    suitOccurence[card.suit]++;
                }
            }


            bool isConsecutive = false;
            int count = 0;
            int lowest = 0;

            //Check Consecutive
            for (int i = 2; i <= 13; i++)
            {
                if (valueOccurence.ContainsKey(i))
                {
                    count++;
                    lowest = i;
                    for (int j = 1; j < 5; j++)
                    {
                        if (valueOccurence.ContainsKey(lowest + j))
                        {
                            count++;
                        }
                    }

                    if (count == 5)
                    {
                        isConsecutive = true;
                    }
                    break;
                }
            }

            //Check pairs
            bool hasPair = false;
            int pairValue = 0;

            bool hasTriple = false;
            int tripleValue = 0;

            bool hasFourKind = false;
            int FourKindValue = 0;

            foreach (KeyValuePair<int, int> keyValue in valueOccurence)
            {
                if (keyValue.Value == 4)
                {
                    hasFourKind = true;
                    FourKindValue = keyValue.Key;
                }
                if (keyValue.Value == 3)
                {
                    hasTriple = true;
                    tripleValue = keyValue.Key;
                }
                if (keyValue.Value == 2)
                {
                    hasPair = true;
                    pairValue = keyValue.Key;
                }
            }

            int rank = 0;

            //High Card
            if (rank == 0)
            {
                rank = highest;
            }

            //One Pair
            if (hasPair)
            {
                rank = 15 * 1 + pairValue;
            }

            //Two Pairs
            if (hasPair)
            {
                valueOccurence.Remove(pairValue);

                bool hasTwoPairs = false;
                foreach (KeyValuePair<int, int> keyValue in valueOccurence)
                {
                    if (keyValue.Value == 2)
                    {
                        hasTwoPairs = true;
                    }
                }

                //Two Pairs
                if (hasTwoPairs)
                {
                        rank = 15 * 2 + pairValue;
                }
            }

            //Three of a Kind
            if (hasTriple)
            {
                    rank = 15 * 3 + tripleValue;
            }

            //Straight
            if (isConsecutive)
            {
                rank = 15 * 4 + highest;
            }

            //Flush
            if (suitOccurence.ContainsValue(5))
            {
                rank = 15 * 5 + highest;
            }

            //Full House
            if (hasPair)
            {
                if (hasTriple)
                {
                        rank = 15 * 6 + tripleValue + pairValue;
                }
            }

            //Four of a Kind
            if (hasFourKind)
            {
                rank = 15 * 7 + FourKindValue;
            }

            if (suitOccurence.ContainsValue(5))
            {
                if (isConsecutive)
                {
                    //Royal Flush
                    if (lowest == 10)
                    {
                        rank = 15 * 9 + highest;
                    }
                    //Straight Flush
                    else
                    {
                        rank = 15 * 8 + highest;
                    }
                }
            }

            return rank;
        }
    }

    class Card
    {
        public int value;
        public char suit;

        static Dictionary<char, int> charValue = new Dictionary<char, int>()
        {
            { 'T', 10 }, { 'J', 11 }, { 'Q', 12 }, { 'K', 13 }, { 'A', 14 }
        };

        public Card(char value, char suit)
        {
            if(charValue.ContainsKey(value))
            {
                this.value = charValue[value];
            }
            else
            {
                this.value = int.Parse(value.ToString());
            }
            this.suit = suit;
        }
    }
}
