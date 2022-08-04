using MindboxGeometry.Helpers;

namespace MindboxGeometry.Shapes;

public class Polygon : Shape
{
    private readonly IEnumerable<Vertex> vertices;

    public Polygon(IEnumerable<Vertex> vertices)
    {
        this.vertices = vertices;
    }

    public override double GetArea()
    {
        if (vertices.Count() == 0)
        {
            return 0;
        }

        return CalculationHelpers.GetPolygonArea(vertices);
    }
}
