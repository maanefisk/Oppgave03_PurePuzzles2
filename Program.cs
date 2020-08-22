using System;

namespace Oppgave03_PurePuzzles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = " ";
            string hash = "#";
            int nedtelling = 8;
            for (int nylinje = 1; nylinje < 5; nylinje++)
            {
                for (int mellomrom = 0; mellomrom < nedtelling; mellomrom++)
                {
                    Console.Write(space);
                }

                for (int ikon = 0; ikon < nylinje; ikon++)
                {
                    Console.Write(hash+hash);
                }

                nedtelling = nedtelling - 1;
                Console.WriteLine();
            }
            for (int b = 5; b < 10; b++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(space);
                }

                for (int a = 0; a < nedtelling; a++)
                {
                    Console.Write(hash+hash);
                }

                nedtelling = nedtelling - 1;

                Console.WriteLine();
            }
        }
    }
}
