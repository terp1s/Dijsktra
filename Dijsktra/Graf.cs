using System.Collections.Generic;

class Graf
{
    public int Cesta { get; set; }
    public List<Vertex> Vrcholy { get; set; } = new List<Vertex>();
    public List<Edge> Edges { get; set; } = new List<Edge>();

    public int NejratsiCesta (Vertex start, Vertex cil)
    {
        Queue<Vertex> que = new Queue<Vertex>(); 
        que.Enqueue (start);
        start.Vzdalenost = 0;

        while(cil.status != Vertex.ennum.U && que.Count != 0)
        {
            que.Dequeue().Projdi(que);
        }

        if(cil.status == Vertex.ennum.U)
        {
            return cil.Vzdalenost;
        }
        else
        {
            return -1;
        }
        
    }
}
