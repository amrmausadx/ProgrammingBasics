using System;
using System.Configuration;
namespace ProgrammingBasics._03_OOP
{
    internal class OOP02
    {
        int x = 0;
        public int xdegree = 5;
        int degree = 0;
        static void static1()
        {
            OOP02 o = new OOP02();
            o.x = 5;

        }
    public static void Main_Properity01()
        {
            _03_OOP.OOP02 o = new _03_OOP.OOP02();
            o.xdegree = -1;
            Console.WriteLine(o.xdegree);
            o.Degree = -1;
            Console.WriteLine(o.Degree);
        }
        static int int_readonlyStatic=5000;
        int int_readonly = 5000;
        public int NotReadOnlyFieldStatic
        {
            get { return int_readonlyStatic; }
            set {  int_readonlyStatic=value; }
        }
        public int NotReadOnlyField
        {
            get { return int_readonly; }
            set { int_readonly = value; }
        }
        public int ReadOnlyField
        {//Read only cannot be assigned to
            get { return int_readonly; }
           // set { int_readonly = value; }
        }
        public int WriteOnlyField
        {//write only cannot be called back
             //get { return int_readonly; }
            set { int_readonly = value; }
        }

        public static void Main_Static03_OneCopy()
        {
            OOP02[] objs = new OOP02[2];
            objs[0] = new OOP02();
            objs[1]=new OOP02();
            Console.WriteLine("objs[0].int_readonly = " + objs[0].NotReadOnlyField);
            Console.WriteLine("objs[1].int_readonly = " + objs[1].NotReadOnlyField);
            Console.WriteLine("objs[0].int_readonlyStatic = " + objs[0].NotReadOnlyFieldStatic);
            Console.WriteLine("objs[1].int_readonlyStatic = " + objs[1].NotReadOnlyFieldStatic);
            objs[1].NotReadOnlyFieldStatic *= 2;
            objs[1].NotReadOnlyField *= 2;
            Console.WriteLine("objs[0].int_readonly = " + objs[0].NotReadOnlyField);
            Console.WriteLine("objs[1].int_readonly = " + objs[1].NotReadOnlyField);
            Console.WriteLine("objs[0].int_readonlyStatic = " + objs[0].NotReadOnlyFieldStatic);
            Console.WriteLine("objs[1].int_readonlyStatic = " + objs[1].NotReadOnlyFieldStatic);

        }
        public static void Main_Static04_ReadWriteOnly()
        {
            OOP02 o = new OOP02();
           // o.ReadOnlyField = o.WriteOnlyField;
        }
        public int Degree
        {
            get {
                string grade = "";
                if (degree >= 85) grade = "Excellent";
                else if (degree >= 75) grade = "V. Good";
                else if (degree >= 65) grade = "Good";
                else if (degree >= 60) grade = "Pass";
                else grade = "Fail";
                Console.WriteLine("Grade: " + grade);
                return degree; }
            set
            {
                if (value >= 0 && value < 100)
                    degree = value;
                else Console.WriteLine("Out of range");
            }
        }
    
    }
}
