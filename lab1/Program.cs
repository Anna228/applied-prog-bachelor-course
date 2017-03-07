using lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Line first = new Line();
            Line second = new Line();
            Console.WriteLine("Введите координаты точек первой линии");
            first.init();
            Console.WriteLine("Введите координаты точек второй линии");
            second.init();
            CalcOfPoint c = new CalcOfPoint();
            Point q;
            q = c.Back(first, second);
            Console.Write("x=");
            Console.WriteLine(q.x);
            Console.Write("y=");
            Console.WriteLine(q.y);
            Console.ReadKey();
        }

    }
}
