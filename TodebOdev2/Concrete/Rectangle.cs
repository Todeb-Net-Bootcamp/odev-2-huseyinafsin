using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodebOdev2.Abstracts;

namespace TodebOdev2.Concrete
{
    public class Rectangle :  Shape
    {
        public override void Area()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rectangle Area:"+Width * Height);
        }
    }
}
