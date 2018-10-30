using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipping
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("#######################################");
                Console.WriteLine("Choose the comand ...");
                Console.WriteLine("f - Flip the coin");
                Console.WriteLine("Esc - exit from program");
                Console.WriteLine("#######################################");

                cki = Console.ReadKey(false); // show the key as you read it
                switch (cki.KeyChar.ToString())
                {
                    case "f":
                        generate();
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public static void generate()
        {
            int FlippingCount = 10;
            int tail = 0, head = 0;
            // Build in random number generator
            Random rnd = new Random();

            Console.WriteLine();
            // Get the random number in range 0 to 1
            for (int i = 0; i < FlippingCount; i++)
            {
                var num = rnd.NextDouble();
                if (num < 0.5)
                {
                    head++;
                    Console.WriteLine("Flipping {0} result Head ({1:0.00})", i + 1, num);
                    continue;
                }
                tail++;
                Console.WriteLine("Flipping {0} result Tail ({1:0.00})", i + 1, num);

            }

            Console.WriteLine("************************************");
            Console.WriteLine("Count of Tails {0}", tail);
            Console.WriteLine("Count of Heads {0}", head);
            Console.WriteLine("************************************");
        }

    }
}
