using MindboxGeometry.Shapes;

namespace MindboxGeometry;

public interface IAreaCalculator
{
    public double Calculate(Shape shape);
}
