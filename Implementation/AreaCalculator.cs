using MindboxGeometry.Shapes;

namespace MindboxGeometry.Implementation;

public class AreaCalculator : IAreaCalculator
{
    public double Calculate(Shape shape) => shape.GetArea();
}