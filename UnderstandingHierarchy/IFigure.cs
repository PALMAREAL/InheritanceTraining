using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandingHierarchy;

namespace UnderstandingHierarchy
{
    public interface IFigure
    {
        string Name { get; set; }
        string Color { get; set; }
        double GetArea();
    }
}
