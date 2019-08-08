using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnderstandingHierarchy.Program;

namespace UnderstandingHierarchy.Figures
{
    public class Rectangle : Figure
    {
        public double Height { get; }
        public double Width { get; }

        public Rectangle(string name, string color, double width, double height) : base(name,color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
