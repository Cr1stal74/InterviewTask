using FigureLib;

double r = 10.745;
Console.WriteLine($"Square of circle with radius = {r}: {Squares.GetSquare(r):#.####}");

double a = 5;
double b = 6;
double c = 7;
Console.WriteLine($"Square of triangle with a = {a}; b = {b}; c = {c}: {Squares.GetSquare(a, b, c):#.####}");

a = 3;
b = 4;
c = 5;

Console.WriteLine($"Triangle with a = {a}; b = {b}; c = {c} is " + (FigureHelper.IsTriangleRight(a, b, c) ? "right" : "not right"));