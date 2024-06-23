using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackClient
{
    public class Card 
    {
        public Suit Suit_ { get; }
        public Face Face_ { get; }
        public int Value_ { get; set; }

        public Card(Suit suit,Face face) 
        {
            Suit_ = suit;
            Face_ = face;

           
            switch (Face_)
            {
                case Face.Jack:
                case Face.Queen:
                case Face.King:
                    Value_=10; break;
                case Face.Ace:
                    Value_ = 11; break;
                default:
                    Value_=(int)Face_; break;
            }
        }
        public string SendDescrition() 
        {
            string suit;

            switch (Suit_)
            {
                case Suit.Diamonds:
                    suit = "Diamond,"; break;
                case Suit.Hearts:
                    suit = "Heart,"; break;
                case Suit.Spades:
                    suit = "Spade,"; break;
                case Suit.Clubs:
                    suit = "Club,"; break;
                default :
                    suit = ""; break;
            }

            string face;
            switch (Face_)
            {
                case Face.Ace:
                    face ="Ace,"; break;
                case Face.Two:
                    face = "Two,"; break;
                case Face.Three:
                    face = "Three,"; break;
                case Face.Four:
                    face = "Four,"; break;
                case Face.Five:
                    face = "Five,"; break;
                case Face.Six:
                    face = "Six,"; break;
                case Face.Seven:
                    face = "Seven,"; break;
                case Face.Eight:
                    face = "Eight,"; break;
                case Face.Nine:
                    face = "Nine,"; break;
                case Face.Ten:
                    face = "Ten,"; break;
                case Face.Jack:
                    face = "Jack,"; break;
                case Face.Queen:
                    face = "Queen,"; break;
                case Face.King:
                    face = "King,"; break;
                default: 
                    face=""; break;
            }

            string value=$"{Value_};";

            return suit + face + value; 

        }

        public void Description()
        {
            Console.WriteLine("");
            Console.Write("Suit-");
            switch (Suit_)
            {
                case Suit.Diamonds:
                    Console.Write("Diamond "); break;
                case Suit.Hearts:
                    Console.Write("Heart "); break;
                case Suit.Spades:
                    Console.Write("Spade "); break;
                case Suit.Clubs:
                    Console.Write("Club "); break;
            }

            Console.Write("Face-");
            switch (Face_)
            {
                case Face.Ace:
                    Console.Write($"Ace"); break;
                case Face.Two:
                    Console.Write($"Two"); break;
                case Face.Three:
                    Console.Write($"Three"); break;
                case Face.Four:
                    Console.Write($"Four"); break;
                case Face.Five:
                    Console.Write($"Five"); break;
                case Face.Six:
                    Console.Write($"Six"); break;
                case Face.Seven:
                    Console.Write($"Seven"); break;
                case Face.Eight:
                    Console.Write($"Eight"); break;
                case Face.Nine:
                    Console.Write($"Nine"); break;
                case Face.Ten:
                    Console.Write($"Ten"); break;
                case Face.Jack:
                    Console.Write($"Jack"); break;
                case Face.Queen:
                    Console.Write($"Queen"); break;
                case Face.King:
                    Console.Write($"King"); break;
            }

            Console.Write(" Value-");
            Console.Write($"{Value_}");
            Console.WriteLine();
        } 
    }
}
