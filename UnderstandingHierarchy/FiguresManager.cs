using System;
using System.Collections.Generic;

namespace UnderstandingHierarchy
{
  public class FiguresManager : IFiguresManager
    {
        private double _totalArea;
        
        public FiguresManager() { }

        public double GetTotalArea(IEnumerable<IFigure> listOfFigures)
        {
            foreach (var item in listOfFigures)
            {
                _totalArea += item.GetArea();
            
            }
            Console.WriteLine("The total area of all figures is {0}", _totalArea);
            Console.ReadLine();

            return _totalArea;
        }
    }
}
