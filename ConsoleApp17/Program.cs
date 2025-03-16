using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] car = new Car[]
            {
                new Car("asd", "asd", 1245),
                new Car("afsf","dsg",1325),
                new Car("hjk","weot", 0992)
            };
            foreach(Car p in car)
            { 
                p.Print();
            }
            Car[] car1 = new Car[1];
            for(int i = 0; i < car1.Length; i++) 
                {
                Console.WriteLine($"Введите марку/модель/год: ");
                string marka = Console.ReadLine();
                string model = Console.ReadLine();
                int year = int.Parse(Console.ReadLine());
                car1[i] = new Car(marka, model, year);
            }
            foreach (Car car1p in car1)
            {
                car1p.Print();
            }

            Console.ReadKey();
        }
    }
}
