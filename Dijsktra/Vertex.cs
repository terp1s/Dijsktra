using System.Linq;
class Vertex
{
    public int Vzdalenost { get; set; } = int.MaxValue;
    public enum ennum { N, O, U };

    public ennum status = ennum.N;
    public List<Vertex> Sousedi { get; set; } = new List<Vertex>();
    public List<Edge> Hrany { get; set; } = new List<Edge>();

    public void Projdi(Queue<Vertex> q)
    {
        foreach(Edge e in Hrany)
        {
            Vertex druhy = e.Vrcholy.Item1 == this ? e.Vrcholy.Item1 : e.Vrcholy.Item2;

            if (druhy.status == ennum.N)
            {
                q.Enqueue(druhy);
                druhy.status = ennum.O;
                druhy.Vzdalenost = this.Vzdalenost = e.Delka;
            }
            else if (druhy.status == ennum.O)
            {
                if(druhy.Vzdalenost > this.Vzdalenost + e.Delka)
                {
                    druhy.Vzdalenost = this.Vzdalenost + e.Delka;
                }
                
            }
        }

        status = ennum.U;
    }
}