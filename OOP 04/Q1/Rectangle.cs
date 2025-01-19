using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_04.Q1.interFace;

namespace OOP_04.Q1
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => Width * Height;

        public void DisplayShapInfo()
        {
            Console.WriteLine($" Rectangle => Width = {Width} , Height = {Height} ,Area = {Area} ");
        }
    }
}
