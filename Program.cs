using MathS;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Test App");
        double a = 2;
        double b = 5;
        double c = 4;
        double radius = 11;
        SquareCircle S = new(radius);
        SquareTriangle Triangle = new(a, b, c);
        S.Square();
        Triangle.Square();
    }
}