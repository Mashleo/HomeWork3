using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            const double  Pi = Math.PI;
            

            Console.WriteLine("*Считаем площать поверхности круглого конуса*");

            Console.Write($"* Введите радиус основанияя r - ");

            double r = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write($"* Введите образующую l - ");

            double l = double.Parse(Console.ReadLine());

            double result = Pi * r * (r + l);

            Console.WriteLine($"Площадь S = {result}"); ;


        }
    }
}
