using Microsoft.SqlServer.Server;
using System;
using System.IO;


namespace ProgrammingBasics
{
    internal class Calc
    {
        public static void Calc_Main()
        {
            string input = "",History="",file = @"D:\testCalc.txt";
            
            double a = 0, b = 0;
            do
            {
                Console.Write(
                    @" 1.) Enter Two Number
 2.) Add Numbers
 3.) Subtract Numbers
 4.) Multiply Numbers
 5.) Show History
 6.) Save History
 7.) Show History
 8.) Open History File
 9.) Exist
 Enter the number of wanted Operation :");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter the value of A :");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Enter the value of B :");
                        b = double.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Add(a, b, ref History);
                        break;
                    case "3": Subtract(a, b, ref History); break;
                    case "4": Multiply(a, b, ref History); break;
                    case "5":
                        Console.WriteLine(History); 
                            break;
                    case "6":
                        StreamWriter sw = new StreamWriter(file, false);
                        sw.Write(History);
                        sw.Close();
                        sw.Dispose();
                        break;
                    case "7":
                        try
                        {
                            int counter = 1;
                            StreamReader sr = new StreamReader(file);
                            while (!sr.EndOfStream)
                            {
                                Console.WriteLine($"Line {counter++} :"+sr.ReadLine());
                            }
                            Console.WriteLine($"All {counter} Lines Listed");
                            sr.Close();sr.Dispose();
                        }
                        catch (Exception e) {
                            Console.WriteLine($"Error Message:{e.Message}");
                        }
                        break;
                    case "8":
                        if(!File.Exists(file))
                        {
                            Console.WriteLine($"file:{file} not found!");
                            break;
                        }
                        System.Diagnostics.Process.Start(file);
                        break;
                    case "9": break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (input != "9");
        }
        static void Add( double a, double b, ref string h)
        {
            string s = $" a ({a}) + b ({b})  = {a + b}";
            Console.WriteLine(s);
            h += s + Environment.NewLine;
        }
        static void Subtract(double a, double b, ref string h)
        {
            string s = $" a ({a}) - b ({b})  = {a - b}";
            Console.WriteLine(s);
            h += s + Environment.NewLine;
        }
        static void Multiply(double a, double b, ref string h)
        {
            string s = $" a ({a}) * b ({b})  = {a * b}";
            Console.WriteLine(s);
            h += s + Environment.NewLine;
        }
    }
}