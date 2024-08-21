using GeometryLib;

var circle = new Circle(5);
var rectangle = new Rectangle(4, 6);
var triangle = new Triangle(3, 4, 5);

Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area()}");
Console.WriteLine($"Perimeter: {circle.Perimeter()}");

Console.WriteLine(rectangle);
Console.WriteLine($"Area: {rectangle.Area()}");
Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");

Console.WriteLine(triangle);
Console.WriteLine($"Area: {triangle.Area()}");
Console.WriteLine($"Perimeter: {triangle.Perimeter()}");