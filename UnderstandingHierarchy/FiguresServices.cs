using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnderstandingHierarchy.Figures;

namespace UnderstandingHierarchy
{
    public class FiguresServices
    {

        public FiguresServices() { }
  
        public void FigureServiceTotalArea()
        {
            var figuresManager = new FiguresManager();
            figuresManager.GetTotalArea(listOfFigures);
        }

        private IEnumerable<IFigure> listOfFigures = new List<IFigure>
        {
            new Square("Square1", "Black", 9),
            new Rectangle("Rectangle1", "White", 8, 5),
            new Triangle("Triangle1", "Red", 6, 4),
            new Circle("Circle1", "Blue", 7)
        };

    }
}
