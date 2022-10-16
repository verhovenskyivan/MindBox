using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox
{
    public class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите сторону C: ");
            double C = Convert.ToDouble(Console.ReadLine());


            double P = (A + B + C) / 2;

            double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            Console.WriteLine("Площадь данного треугольника: " + S);    
        }
    }
}
