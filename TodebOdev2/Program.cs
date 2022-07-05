// See https://aka.ms/new-console-template for more information

using TodebOdev2.Abstracts;
using TodebOdev2.Concrete;
public class Program
{
    public static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black;

        Rectangle rectangle  = new Rectangle();
        rectangle.Width = 5;
        rectangle.Height = 4;
        rectangle.Area();

        Triangle triangle = new Triangle();
        triangle.Width = 5;
        triangle.Height = 4;
        triangle.Area();

        Console.ForegroundColor= ConsoleColor.White;
    }
}

