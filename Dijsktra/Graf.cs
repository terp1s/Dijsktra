class Graf
{
    public int Cesta { get; set; }  
    public Vertex[] Vrcholy { get; set; } 
    public List<Edge> Edges { get; set; }

    public int NejratsiCesta (Vertex start, Vertex cil)
    {
        Queue<Vertex> que = new Queue<Vertex>(); 
        que.Enqueue (start);

        while(cil.status != Vertex.ennum.U)
        {
            que.Dequeue().Projdi(que);
        }

        return cil.Vzdalenost;
    }
}
