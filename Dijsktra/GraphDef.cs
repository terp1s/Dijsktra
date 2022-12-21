using System;
using System.Collections.Generic;
using System.Linq;

class GraphDef
{
    public static Graf Nacti2()
    {
        string[] vrchran = Console.ReadLine().Split();
        int vrcholy = int.Parse(vrchran[0]);
        int hrany = int.Parse(vrchran[1]);
        (int, int, int)[] hrana = new (int, int, int)[hrany];

        for (int i = 0; i < hrany; i++)
        {
            hrana[i] = Console.ReadLine().Split() switch {var x => (int.Parse(x[0]), int.Parse(x[1]), int.Parse(x[2]))};
        }

        return Nacti(vrcholy, hrany, hrana);
    }
    public static Graf Nacti(int pocetVrcholu, int pocetHran, (int a,int b,int s)[] hrany)
    {
        Graf graf = new Graf();
        

        hrany = hrany.OrderByDescending(t => t.Item3).ToArray();
        hrany = hrany.Reverse().ToArray();

        for (int i = 0; i < pocetVrcholu; i++)
        {
            Vertex vertex = new Vertex();
            graf.Vrcholy.Add(vertex);
            vertex.Index = i;
        }

        foreach((int a,int b,int s) hrana in hrany)
        {
            graf.Vrcholy[hrana.a].Sousedi.Add(graf.Vrcholy[hrana.b]);
            graf.Vrcholy[hrana.b].Sousedi.Add(graf.Vrcholy[hrana.a]);
            Edge edge = new Edge();
            graf.Vrcholy[hrana.a].Hrany.Add(edge);
            graf.Vrcholy[hrana.b].Hrany.Add(edge);
            edge.Vrcholy = (graf.Vrcholy[hrana.a], graf.Vrcholy[hrana.b]);
            edge.Delka = hrana.s;
            graf.Edges.Add(edge);

        }

        return graf;    
    }

}
