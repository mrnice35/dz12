using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("введите значение точки по оси координат X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значение точки по оси координат Y");
            int y = Convert.ToInt32(Console.ReadLine());*/
            Circle circle = new Circle();
            circle.ToCircumference();
            circle.ToArea();
            circle.InACircle();
            Console.ReadKey();

        }

    }
    class Circle
    {
        public static double r = 15;
        public static double x0 = 3;
        public static double y0 = 4;

        public void ToCircumference()
        {
            double L = 2 * Math.PI * r;
            Console.WriteLine("Длина окржуности равна {0}", L);
        }
        public void ToArea()
        {
            double S = Math.PI * r * r;
            Console.WriteLine("Площадь круга равна {0}", S);
        }
        public void InACircle(double x1=50, double y1 = 4)
        {
            if (Math.Pow(x0 - x1, 2) + Math.Pow(y0 - y1, 2) < r * r)
            {
             Console.WriteLine("точка лежит внутри круга");
            }
            else
            {
             Console.WriteLine("точка лежит вне заданного круга");
            }
        }
    }
}

            

           