using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz12
{
    public class Program
    {
        public static void Main()
        {
            /*Console.WriteLine("введите значение точки по оси координат X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите значение точки по оси координат Y");
            int y = Convert.ToInt32(Console.ReadLine());*/

            double r = 15;
            double x0 = 3;
            double y0 = 4;
            double x1 = 50;
            double y1 = 4;
            Circle.L(r);
            Circle.S(r);
            Circle.InACircle(x1,y1,r, x0, y0);
            Console.ReadKey();
        }



    }
    static class Circle
    {

        public static void L(double r)
        {
            double L = 2 * Math.PI * r;
            Console.WriteLine("Длина окржуности равна {0}", L);
        }
        public static void S(double r)
        {
            double S = Math.PI * r * r;
            Console.WriteLine("Площадь круга равна {0}", S);
        }
        public static void InACircle(double x1, double y1, double r, double x0, double y0)
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



