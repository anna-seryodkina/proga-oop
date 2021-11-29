using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CardManager manager = new CardManager();

            manager["spades"] = new Spades();
            manager["clubs"] = new Clubs();
            manager["hearts"] = new Hearts();
            manager["diamonds"] = new Diamonds();


            manager["spades"].Clone("6");
            manager["spades"].Clone("7");
            manager["spades"].Clone("8");
            manager["spades"].Clone("9");
            manager["spades"].Clone("10");
            manager["spades"].Clone("J");
            manager["spades"].Clone("Q");
            manager["spades"].Clone("K");

            manager["hearts"].Clone("6");
            manager["hearts"].Clone("7");
            manager["hearts"].Clone("8");
            manager["hearts"].Clone("9");
            manager["hearts"].Clone("10");
            manager["hearts"].Clone("J");
            manager["hearts"].Clone("Q");
            manager["hearts"].Clone("K");

            manager["clubs"].Clone("6");
            manager["clubs"].Clone("7");
            manager["clubs"].Clone("8");
            manager["clubs"].Clone("9");
            manager["clubs"].Clone("10");
            manager["clubs"].Clone("J");
            manager["clubs"].Clone("Q");
            manager["clubs"].Clone("K");

            manager["diamonds"].Clone("6");
            manager["diamonds"].Clone("7");
            manager["diamonds"].Clone("8");
            manager["diamonds"].Clone("9");
            manager["diamonds"].Clone("10");
            manager["diamonds"].Clone("J");
            manager["diamonds"].Clone("Q");
            manager["diamonds"].Clone("K");

            Console.ResetColor();

            // Wait for user
            Console.ReadKey();
        }

        abstract class Card
        {
            public abstract Card Clone(string r);
        }


        class Clubs : Card
        {
            string rank;
            public override Card Clone(string r)
            {
                this.rank = r;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(" ----------------");
                Console.WriteLine("|   " + r + "  clubs     |");
                Console.WriteLine("|            " + r + "   |");
                Console.WriteLine(" ----------------");
                Console.ResetColor();

                return this.MemberwiseClone() as Card;
            }
        }
        class Spades : Card
        {
            string rank;
            public override Card Clone(string r)
            {
                this.rank = r;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(" ----------------");
                Console.WriteLine("|   " + r + "  spades    |");
                Console.WriteLine("|            " + r + "   |");
                Console.WriteLine(" ----------------");

                return this.MemberwiseClone() as Card;
            }
        }
        class Hearts : Card
        {
            string rank;
            public override Card Clone(string r)
            {
                this.rank = r;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(" ----------------");
                Console.WriteLine("|   " + r + "  hearts    |");
                Console.WriteLine("|            " + r + "   |");
                Console.WriteLine(" ----------------");
                Console.ResetColor();

                return this.MemberwiseClone() as Card;
            }
        }
        class Diamonds : Card
        {
            string rank;
            public override Card Clone(string r)
            {
                this.rank = r;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(" ----------------");
                Console.WriteLine("|   " + r + " diamonds   |");
                Console.WriteLine("|            " + r + "   |");
                Console.WriteLine(" ----------------");
                Console.ResetColor();

                return this.MemberwiseClone() as Card;
            }
        }

        class CardManager
        {
            private Dictionary<string, Card> _cards = new Dictionary<string, Card>();

            // Indexer
            public Card this[string key]
            {
                get { return _cards[key]; }
                set { _cards.Add(key, value); }
            }
        }

    }
}
