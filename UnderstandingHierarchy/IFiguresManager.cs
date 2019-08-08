using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingHierarchy
{
    public interface IFiguresManager
    {
        double GetTotalArea(IEnumerable<IFigure> listOfFigures);
    }
}
