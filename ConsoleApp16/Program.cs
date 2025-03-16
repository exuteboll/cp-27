using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[3];
            points[0] = new Point(1,2);
            points[1] = new Point(2,3);
            points[2] = new Point(3,4);
            foreach (Point n in points)
            {
                n.Print();
            }
            Console.WriteLine("Введите: ");
            int p = int.Parse(Console.ReadLine());
            Point[] point1 = new Point[p];
            for (int i = 0; i < p; i++)
            {
                Console.Write($"X{i + 1}: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write($"Y{i +1}: ");
                double y = double.Parse(Console.ReadLine());
                point1[i] = new Point(x, y);
            }
            foreach(Point w in point1)
            {
                w.Print();
            }
            
            Console.ReadKey();

        }
    }
}
