namespace MindboxGeometry.Helpers;

internal static class CalculationHelpers
{
    public static double GetCircleArea(double radius) => Math.PI * Math.Pow(radius, 2);

    public static double GetTriangleArea(double s1, double s2, double s3)
    {
        var hp = (s1 + s2 + s3) / 2;

        //(new[] {s1, s2, s3.Value}).Aggregate(hp, (prev, next) => prev * (hp - next));
        return Math.Sqrt(hp * (hp - s1) * (hp - s2) * (hp - s3));
    }

    public static double GetPolygonArea(IEnumerable<Vertex> vertices)
    {
        var points = vertices.ToList();
        points.Add(points[0]);

        return Math.Abs(vertices.Take(vertices.Count() - 1)
           .Select((p, i) => (points[i + 1].X - p.X) * (points[i + 1].Y + p.Y))
           .Sum() / 2);
    }
}