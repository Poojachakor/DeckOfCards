using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Numerics;
using System;

namespace DeckOfCardsDay11
{
    public class Program
    {
        public static void Main()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Shuffle();

            string[,] cards = deck.DealCards();

            // Print the Cards received by the 4 Players using 2D Array
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Player {i + 1}: ");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write($"{cards[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
            
        
    }
}


        





    
