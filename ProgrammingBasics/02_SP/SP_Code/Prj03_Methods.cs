using System;

namespace ProgrammingBasics_SP
{
    internal class Prj03_Methods
    {
        public static int GetInt()
        {
            int i = 0;
            Console.Write("Enter integer : ");
            i = int.Parse(Console.ReadLine());
            return i;
        }
        public static void PrintInt(int v)
        {
            Console.WriteLine($"PrintInt(int): Printing integer : {v}");
        }
        public static void PrintInt(int v, string Name)
        {
            Console.WriteLine($"PrintInt(int,string): Printing {Name} integer : {v}");
        }
        public static void PrintInt2(int v, string Name = "NoName")
        {
            Console.WriteLine($"PrintInt2(int,string=): Printing {Name} integer : {v}");
        }
        public static void Main_MethodCall()
        {
            int i = GetInt(), j = GetInt(), k = GetInt(), l = GetInt();
            PrintInt(i, "i");
            PrintInt2(j, "j"); PrintInt2(k);
            PrintInt(l);

            Console.WriteLine("Named Parameter");
            PrintInt2(Name: "j", v: j);

            /*
            int i = 0,j=0,k=0;
            Console.Write("Enter integer : ");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter integer : ");
            j = int.Parse(Console.ReadLine());
            Console.Write("Enter integer : ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine($"Printing {i} integer : {i}");
            Console.WriteLine($"Printing {j} integer : {j}");
            Console.WriteLine($"Printing {k} integer : {k}");
             */
        }
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }
        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
        static int PlusMethod(int x, int y)//PlusMethod(int,int)
        {
            Console.WriteLine("Calling::PlusMethod(int,int)");
            return x + y;
        }

        static double PlusMethod(double x, double y)//PlusMethod(double,double)
        {
            Console.WriteLine("Calling::PlusMethod(double,double)");
            return x + y;
        }
        static double PlusMethod(double x, int y)//PlusMethod(double,int)
        {
            Console.WriteLine("Calling::PlusMethod(double,int)");
            return x + y;
        }
        public static void Main_OverLoading()
        {
            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            double myNum3 = PlusMethod(4.3, 2);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        public static void Main_NoOverLoading()
        {
            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
        static void Paramters(int x, ref int y, out int z)
        {
            x = y = z = 5;// y = 5 
            Console.Write($"in Parameter Method :: ");
            Console.WriteLine($"x1={x},x2={y},x3={z}");
        }
        public static void Main_Parameters()
        {
            int x1 = 0, x2 = 50, x3 = 100;
            Console.WriteLine($"x1={x1},x2={x2},x3={x3}");
            Paramters(x1, ref x2, out x3);
            Console.WriteLine("After");
            Console.WriteLine($"x1={x1},x2={x2},x3={x3}");
        }

        public static int Fac_rec(int n)
        {
            int res = 1;
            if (n > 1)
                return n* Fac_rec(n - 1);
            return res;
        }
        public static int Fac_it(int n)
        {
            int res = 1;
            if (n > 1)
                for (int i = n; n > 1; n--)
                    res *= n;
            return res;
        }
        public static void Main_it_vs_rec()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"it: Fac({i + 1})={i + 1}! = {Fac_it(i + 1)} ");
            for (int i = 0; i < n; i++)
                Console.WriteLine($"rec: Fac({i + 1})={i + 1}! = {Fac_rec(i + 1)} ");
        }
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */
