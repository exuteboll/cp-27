using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }

        public Car() { }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public void Print()
        {
            Console.WriteLine($"Марка: {make}\t модель: {model}\t год: {year}");
        }
    }
}
