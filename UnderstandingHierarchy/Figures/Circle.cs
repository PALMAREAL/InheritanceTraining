using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnderstandingHierarchy.Program;

namespace UnderstandingHierarchy.Figures
{
    public class Circle : Figure
    {
     
        public double Radius { get; }

        public Circle(string name, string color, double radius) : base(name, color)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
           return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
