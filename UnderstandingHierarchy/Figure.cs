using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingHierarchy
{
    public abstract class Figure : IFigure
    {

        public string Name { get; set; }
        public string Color { get; set; }


        protected Figure(string name, string color)
        {
            Color = color;
            Name = name;
        }

        public abstract double GetArea();
    }


}
