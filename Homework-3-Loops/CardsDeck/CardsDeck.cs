using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 09
.Print a Deck of 52 Cards
 * Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
 * The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2
 * to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a 
 * switch-case statement.
 */


class CardsDeck
{
    static void Main()
    {
        string[] cardSuit = { "♣", "♦", "♥", "♥" };
        for (int n = 2; n <= 13; n++)
        {
            for (int i = 0; i < 4; i++)
            {
                switch (n)
                {

                    case 2:
                        Console.Write("2{0}", cardSuit[i]);
                        break;
                    case 3:
                        Console.Write("3{0}", cardSuit[i]);
                        break;
                    case 4:
                        Console.Write("4{0}", cardSuit[i]);
                        break;
                    case 5:
                        Console.Write("5{0}", cardSuit[i]);
                        break;
                    case 6:
                        Console.Write("6{0}", cardSuit[i]);
                        break;
                    case 7:
                        Console.Write("7{0}", cardSuit[i]);
                        break;
                    case 8:
                        Console.Write("8{0}", cardSuit[i]);
                        break;
                    case 9:
                        Console.Write("9{0}", cardSuit[i]);
                        break;
                    case 10:
                        Console.Write("J{0}", cardSuit[i]);
                        break;
                    case 11:
                        Console.Write("Q{0}", cardSuit[i]);
                        break;
                    case 12:
                        Console.Write("K{0}", cardSuit[i]);
                        break;
                    case 13:
                        Console.Write("A{0}", cardSuit[i]);
                        break;
                    default:
                        Console.Write("You entered invalid value for switch.");
                        break;
                }

            }
            Console.WriteLine();
        }
    }
}

