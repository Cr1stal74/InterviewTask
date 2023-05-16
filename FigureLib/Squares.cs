namespace FigureLib;

// To add a new figure just create another overload of "GetSquare" method
public static class Squares
{
    // Get circle square
    public static double GetSquare(double radius)
    {
        if(radius <= 0)
        {
            throw new ArgumentException("Radius must be positive!");
        }
        return Math.PI * radius * radius;
    }

    // Get triangle square
    public static double GetSquare(double a, double b, double c)
    {
        if(!FigureHelper.IsTriangleCorrect(a, b, c))
        {
            throw new ArgumentException("Triangle is not correct!");
        }

        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}