namespace MindboxGeometry.Shapes;

public class Triangle : Shape
{
    private readonly double s1;
    private readonly double s2;
    private readonly double? s3;

    public Triangle(double side1, double side2, double side3)
    {
        s1 = side1;
        s2 = side2;
        s3 = side3;
    }

    protected Triangle(double side1, double side2)
    {
        s1 = side1;
        s2 = side2;
    }

    public override double GetArea()
    {
        if (!s3.HasValue)
        {
            return s1 * s2 / 2;
        }

        var hp = (s1 + s2 + s3.Value) / 2;

        //(new[] {s1, s2, s3.Value}).Aggregate(hp, (prev, next) => prev * (hp - next));
        return Math.Sqrt(hp * (hp - s1) * (hp - s2) * (hp - s3.Value));
    }
}
