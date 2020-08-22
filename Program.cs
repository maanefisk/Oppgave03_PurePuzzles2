using System;

namespace Oppgave03_PurePuzzles2
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = " ";
            for (int nylinje = 0; nylinje < 8; nylinje++)
            {
                Console.WriteLine("new");
                for (int mellomrom = 0; mellomrom < nylinje; mellomrom++)
                {
                    Console.Write("X");
                }
            }
        }
    }
}
