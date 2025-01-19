using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Q1.interFace
{
    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }

    }
}
