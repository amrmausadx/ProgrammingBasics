using System;
namespace ProgrammingBasics._03_OOP
{
    internal class OOP01
    {
        static Random r = new Random(DateTime.Now.Millisecond);    
        public static string x = "this is a string";
        public string xx = "this is a string";
        public static void Static()
        {
            _03_OOP.OOP01.x = "10";
            _03_OOP.OOP01 o = new _03_OOP.OOP01();
            o.xx = _03_OOP.OOP01.x;
            test.OOP01.x = 10;
        }
        public static void Instance()
        {
           // int a = 0;
            Console.WriteLine("Program Begin");
            OOP01[] x1 = new OOP01[5];
            for (int i = 0; i < 5; i++)
                x1[i] = new OOP01(i);
                
            
            x1[2].DisplayName();
            Console.WriteLine("Prgram End!");
        }
        public static void StaticConstructor()
        {
            Console.WriteLine("Program Begin");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);
            OOP01[] x1 = new OOP01[5];
            for (int i = 0; i < 5; i++)
                x1[i] = new OOP01(i);
            Console.WriteLine("Prgram End!");
        }
        static OOP01()
        {
            Console.WriteLine("Static Constructor");
        }
        public OOP01()
        {
        }
        string Name="";
        public OOP01( int i)
        {
            Name = "OOP01:" + (i + 1) + " " + r.Next(100);
            Console.WriteLine("A new object "+ Name + " Arrived! ");
        }
        public void DisplayName()
        {
            Console.WriteLine(" object :" + Name);
        }
    }
}
namespace ProgrammingBasics.test
{
    internal class OOP01
    {
        public static int x = 10;
    }
}
