using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_04.Q1.interFace;

namespace OOP_04.Q1
{
    public class Circle : ICircle
    {
        public double radius { get; set; }

        public double Area => Math.PI * radius * radius;

        public void DisplayShapInfo()
        {
            Console.WriteLine($" Circle => radius = {radius} , Area = {Area}");
        }
    }
}
