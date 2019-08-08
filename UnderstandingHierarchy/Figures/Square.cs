using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static UnderstandingHierarchy.Program;

namespace UnderstandingHierarchy.Figures
{
    public class Square : Figure
    {
        public double Width { get;}

        public Square(string name, string color, double width) : base(name, color)
        {
            Width = width;
        }

        public override double GetArea()
        {
            return Math.Pow(Width, 2);
        }
    }
}
