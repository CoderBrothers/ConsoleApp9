using ConsoleApp9;

Square square = new();
square.Side = 4.2;
Console.WriteLine(square.Side);
Console.WriteLine(square.Area());
Console.WriteLine(square.Perimeter());
Console.WriteLine();
Triangle triangle = new();
triangle.Side1 = 3;
triangle.Side2 = 4;
triangle.Side3 = 5;
Console.WriteLine(triangle.Area());
Console.WriteLine(triangle.Perimeter());
Console.WriteLine();
Rectangle rectangle = new();
rectangle.Side1 = 3;
rectangle.Side2 = 4;
Console.WriteLine(rectangle.Area());
Console.WriteLine(rectangle.Perimeter());
Console.WriteLine();
Circle circle = new();
circle.Side1 = 3;
Console.WriteLine(circle.Area());
Console.WriteLine(circle.Perimeter());

