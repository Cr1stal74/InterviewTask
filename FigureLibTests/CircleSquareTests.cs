using FigureLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibTests;

internal class CircleSquareTests
{
    [Test]
    public void Square_With_Correct_Radius()
    {
        double r = 5;
        var square = Math.PI * Math.Pow(r, 2);

        Assert.That(Squares.GetSquare(r), Is.EqualTo(square));
    }

    [Test]
    public void Square_With_Wrong_Radius()
    {
        double r = -5;

        Assert.Throws<ArgumentException>(() => Squares.GetSquare(r));
    }
}
