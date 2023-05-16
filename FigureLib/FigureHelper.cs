using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib;

public class FigureHelper
{
    // корявенько, да
    public static bool IsTriangleRight(params double[] sides)
    {
        if(!IsTriangleCorrect(sides))
        {
            throw new ArgumentException("Triangle is not correct");
        }

        var hypIndex = Array.IndexOf(sides, sides.Max());
        double sum = 0;

        for(int i = 0; i < sides.Length; i++)
        {
            if (i == hypIndex)
                continue;
            sum += Math.Pow(sides[i], 2);
        }

        return Math.Pow(sides[hypIndex], 2) == sum;
    }

    // метод нужен только внутри библиотеки, поэтому модификатор доступа - internal
    internal static bool IsTriangleCorrect(params double[] sides)
    {
        if (sides[0] >= sides[1] + sides[2] || sides[1] >= sides[0] + sides[2] || sides[2] >= sides[0] + sides[1])
        {
            return false;
        }

        if (sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0)
        {
            return false;
        }

        return true;
    }
}
