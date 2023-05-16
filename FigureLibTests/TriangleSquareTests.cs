using FigureLib;

namespace FigureLibTests;

public class TriangleSquareTests
{
    [Test]
    public void Square_With_Correct_Sides()
    {
        var a = 2.2;
        var b = 5;
        var c = 6;

        // ответ верный, но из-за того, что компьютер мыслит нулями и единичками, у него не всегда точно получается посчитать дробь при делении
        var square = (float)5.28; // definitely correct answer

        Assert.That((float)Squares.GetSquare(a, b, c), Is.EqualTo(square));
    }

    [TestCase(1, 2, 4)]
    [TestCase(-5, -7, -9)]
    public void Square_With_Wrong_Sides(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => Squares.GetSquare(a, b, c));
    }
}
