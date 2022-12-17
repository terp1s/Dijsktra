class GraphDef
{
    public static Graf Nacti(int pocetVrcholu, int pocetHran, (int a,int b,int s)[] hrany)
    {
        Graf graf = new Graf();
        List<(int a, int b, int s)> trojice = (List<(int a, int b, int s)>)hrany.OrderBy(x => x.s); 

        for (int i = 0; i < pocetVrcholu; i++)
        {
            Vertex vertex = new Vertex();
            graf.Vrcholy[i] = vertex;
            
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
