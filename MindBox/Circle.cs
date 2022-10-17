using MindBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MindBox
{
    public class Circle
    {
        public Circle(double Radius)
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Недопустимое значение радиуса. ");
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radius * Radius; Console.WriteLine("Площадь круга: " + Area);
            Console.ReadKey();
        }
    }
}

