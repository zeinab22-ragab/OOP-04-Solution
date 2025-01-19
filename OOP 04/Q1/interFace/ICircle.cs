using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04.Q1.interFace
{
    public interface ICircle : IShape
    {
        double radius { get; set; }
    }
}
