using MindboxGeometry.Helpers;

namespace MindboxGeometry.Shapes;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return CalculationHelpers.GetCircleArea(radius);
    }
}
