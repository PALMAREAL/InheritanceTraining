using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace UnderstandingHierarchy
{
    public class Program
    {

        static void Main(string[] args)
        {
            var figuresService = new FiguresServices();
            figuresService.FigureServiceTotalArea();
        }

    }
}






















//foreach (var item in listOfFigures)
//{
//item.GetArea();
//Console.WriteLine("The area of {0} with color {1} is {2}.", item.Name, item.Color, item.GetArea());
//Console.ReadLine();
//}






//private static double _totalArea;


//static void Main(string[] args)
//{
//IEnumerable<IFigure> listOfFigures = new List<IFigure>
//{
//    new Square("Sqr1", "Black", 9),
//    new Rectangle("Rct1", "White", 8, 5),
//    new Triangle("Tri1", "Red", 6, 4),
//    new Circle("Cir1", "Blue", 6)
//};

//GetTotalArea(listOfFigures);
//Console.WriteLine("The total Area is {0}:", _totalArea);
//Console.ReadLine();
//}

//private static void GetTotalArea(IEnumerable<IFigure> listOfFigures)
//{
//foreach (var item in listOfFigures)
//{

//    _totalArea += item.GetArea();
//    Console.WriteLine("The area of {0} with color {1} is {2}.",
//        item.Name,
//        item.Color,
//        item.GetArea());

//}

//}


//var figuresManager = new FiguresManager();
//Console.WriteLine("The total area of all figures is {0}", figuresManager.GetTotalArea());
//Console.ReadLine(); 



// EJEMPLO 1

//var listaDeFiguras = new List<Figure>()
//{
//    new Circle("Cir1","White", 7),
//    new Rectangle("Rc1","Black", width: 4, height: 7),
//    new Square("Sqr1","Red", 9),
//    new Triangle("Tr1","blue",4,5)
//};

//foreach (var item in listaDeFiguras)
//{
//    Console.WriteLine("The area of {0} with color {1} is {2}: ", item.Name, item.Color, item.GetArea());
//    Console.ReadLine();
//}

//foreach (var item in listaDeFiguras)
//{
//    totalArea += item.GetArea();
//    Console.WriteLine("The total area of all figures is {0}", totalArea);
//    Console.ReadLine();
//}
