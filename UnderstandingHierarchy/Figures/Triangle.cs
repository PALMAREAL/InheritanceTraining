using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnderstandingHierarchy.Program;

namespace UnderstandingHierarchy.Figures
{
    public class Triangle : Figure
    {

        public double Height { get; }
        public double Width { get; }

        public override double GetArea()
        {
            return (Width * Height) / 2;
        }

        public Triangle(string name, string color, double width, double height) : base(name,color)
        {
            Width = width;
            Height = height;
        }
    }
}
