using System;

namespace inluppg3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra?");
            int ans = int.Parse(Console.ReadLine());

            if (ans * 80 <= 950)
            {
                Console.WriteLine(ans * 80 + " kr");
            }
            else
            {
                Console.WriteLine("Du får inte hyra så länge");
            }
        }
    }
}