using TodebOdev2.Abstracts;

namespace TodebOdev2.Concrete;

public class Triangle :  Shape
{
    public override void Area()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Triangle Area:"+(Width * Height) / 2);
    }
}