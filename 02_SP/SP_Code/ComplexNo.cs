using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingBasics
{
    internal struct Complex
    {
        public double real;
        public double img;
        public void Read()
        {
            Console.Write("Enter real Component :");
            real = double.Parse(Console.ReadLine());
            Console.Write("Enter imaginary Component :");
            img = double.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"{real}+{img}i");
        }
        public void Add(Complex a)
        {
            real+= a.real;
            img += a.img;
        }public void Subtract(Complex a)
        {
            real -= a.real;
            img -= a.img;
        }
    }
    internal class ComplexNo
    {
        public static void ComplexMain()
        {
            Complex a, b;
            a.real = 5;a.img = 10;
            b.real = 3;b.img =- 20;
            Console.Write("Printing  a     :"); a.Print();
            Console.Write("Printing  b     :"); b.Print();
            a.Add(b);
            Console.Write("Printing  a+b   :"); a.Print();
            a.Subtract(b);
            Console.Write("Printing  a+b-b :"); a.Print();
            Complex c= new Complex();
            c.Read();
            c.Print();
        }
    }
}
