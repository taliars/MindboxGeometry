using MindboxGeometry;
using MindboxGeometry.Shapes;
using Moq;
using NUnit.Framework;

[TestFixture]
public class AreaCalculatorTest
{

    [Test]
    public void Calculate()
    {
        var mock = new Mock<IAreaCalculator>();
        mock.Setup(m => m.Calculate(new RectagularTriangle(10, 5))).Returns(25);
        Assert.AreEqual(25, mock.Object.Calculate(new RectagularTriangle(10, 5)));
    }
}