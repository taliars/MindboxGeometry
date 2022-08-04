using MindboxGeometry.Helpers;

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

        return CalculationHelpers.GetTriangleArea(s1, s2, s3.Value);
    }
}
