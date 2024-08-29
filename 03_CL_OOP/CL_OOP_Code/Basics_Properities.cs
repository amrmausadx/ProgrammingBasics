using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_CL
{
    internal class Basics_Properities
    {
        private int private_x = 0;
        internal int internal_x = 0;
        protected int protected_x = 0;
        public int public_x = 0;

        public static int static_x = 0;

        public static void Main01()
        {
            Basics_Properities.static_x = 5;
            Basics_Properities o = new Basics_Properities();
            o.private_x = o.public_x =
                o.internal_x = o.protected_x = 5;

            o.X = 15;
            Console.WriteLine("Property x equals:" + o.X);
            
            Console.WriteLine("Asign -1 toProperty x ");
            o.X = -1;
            Console.WriteLine("Property x equals:" + o.X);
        }

        public static void Main02_ReadOnly()
        {
            Basics_Properities o = new Basics_Properities();
 

            o.X = 15;
            //o.ReadOnlyX = o.WriteOnlyx;
            Console.WriteLine("Property x equals:" + o.X);

            Console.WriteLine("Asign -1 to Property private_x using other property");
            o.WriteOnlyx = -1;
            Console.WriteLine("Property x equals:" + o.X);

        }
        //Assume private_x is thermal degree with allowed values between 0 and 60
        public int X
        {
            get { return private_x; }
            set {
                if (value > 60 || value < 0)
                {
                    Console.WriteLine("Out of Range"); return;
                }
                private_x = value; }
        }
        public int ReadOnlyX
        {
            get { return private_x; }
        }
        public int WriteOnlyx
        {
            set {  private_x=value; }
        }

    }
    internal class test:Basics_Properities
    {
        void f1()
        {
            Basics_Properities.static_x = 5;
            test o = new test();
            //o.private_x =
            o.X =
            o.public_x =
                o.internal_x = o.protected_x = 5;

        }
    }
}
