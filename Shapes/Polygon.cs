namespace MindboxGeometry.Shapes;

public class Polygon : Shape
{
    private readonly List<Vertex> vertices;

    public Polygon(IEnumerable<Vertex> vertices)
    {
        this.vertices = vertices.ToList();
    }

    public override double GetArea()
    {
        if (vertices.Count() == 0)
        {
            return 0;
        }

        vertices.Add(vertices[0]);
        return Math.Abs(vertices.Take(vertices.Count - 1)
           .Select((p, i) => (vertices[i + 1].X - p.X) * (vertices[i + 1].Y + p.Y))
           .Sum() / 2);
    }
}
