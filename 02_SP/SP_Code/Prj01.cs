using System;

namespace ProgrammingBasics_SP
{
    internal class Prj01
    {
        public static void Main_Prj01()
        {
            int i = 0;
            int x = 6; i++;
            Console.WriteLine(x);
            x = 70; i++;
            Console.WriteLine(x);
            x += 20; i++;// x = x + 20;//
            Console.WriteLine(x);

            Console.Write("Enter new X value:");
            string s = Console.ReadLine();
            x = int.Parse(s); i++;
            if (x > 100) Console.WriteLine("X>100");
            else if (x == 100) Console.WriteLine("X=100");
            else Console.WriteLine("X<100");
            Console.WriteLine("the new value of x is " + x + " After " + i + " changes");
            Console.WriteLine($"the new value of x is {x} After {i} changes");
            Console.ReadLine();
            /*
            - 
            _ 
            @
            #
           */
        }
        public static void Main_Modelus()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine($"{i} % {2} = {i % 2} because {i / 2}X{2}={i / 2 * 2} => {i}-{i / 2 * 2}={i % 2}");
        }
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */