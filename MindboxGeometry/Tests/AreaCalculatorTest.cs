using MindboxGeometry.Helpers;
using MindboxGeometry.Implementation;
using MindboxGeometry.Shapes;
using NUnit.Framework;

[TestFixture]
public class AreaCalculatorTest
{
    private AreaCalculator areaCalculator;

    public AreaCalculatorTest()
    {
        areaCalculator = new AreaCalculator();
    }

    [TestCaseSource(nameof(_testCases))]
    public void Calculate(Shape shape, double expectedResult)
    {
        var result = areaCalculator.Calculate(shape);
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    static object[] _testCases =
    {
        new object[] { new Circle(10), CalculationHelpers.GetCircleArea(10)},
        new object[] { new RectagularTriangle(10, 5), (10 * 5) / 2},
        new object[] { new Triangle(10, 20, 10), CalculationHelpers.GetTriangleArea(10, 20, 10)},
        new object[] { new Polygon(Vertices), CalculationHelpers.GetPolygonArea(Vertices)},
        new object[] { new Polygon(Array.Empty<Vertex>()), 0}
    };

    static Vertex[] Vertices => new[] {
        new Vertex(2, 4, 0),
        new Vertex(1, 7, 0),
        new Vertex(5, 7, 0)
    };
}
