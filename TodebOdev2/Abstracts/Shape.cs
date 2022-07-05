using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodebOdev2.Abstracts
{
    public abstract class  Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Area()
        {
        }

    }
}
