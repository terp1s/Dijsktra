
using System;

namespace Dijkstra
{
    class Program
    {
        public static void Main(string[] args)
        {
            Graf graf = GraphDef.Nacti2();

            string[] cesta = Console.ReadLine().Split();
            int start = int.Parse(cesta[0]);
            int cil = int.Parse(cesta[1]);

            Console.WriteLine(graf.NejratsiCesta(graf.Vrcholy[start], graf.Vrcholy[cil]));

            //(int, int, int)[] hrany = { (0, 1, 1), (1, 2, 1), (1, 3, 1), (3, 4, 1), (5, 4, 4), (5, 2, 6), (1, 5, 8), (1, 4, 3) };
            //Graf graf = GraphDef.Nacti(6, 8, hrany);

            //int cesta = graf.NejratsiCesta(graf.Vrcholy[1], graf.Vrcholy[5]);
        }
    }
}
