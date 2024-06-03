using System;


namespace ProgrammingBasics_SP
{
    internal class Prj02
    {
        public static void Main_str_Prec()
        {
            string x = "10";
            int y = 20;
            int h = 10;

            string z = x + (y + h);
            Console.WriteLine(z);
        }
        public static void Main_str_indexof()
        {
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("ll"));
        }
        public static void Main_str_substring()
        {
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("z");
            //"Ahmed".IndexOf((char)65)
            Console.WriteLine($"index of z is {charPos}");

            charPos = name.IndexOf("D");
            Console.WriteLine($"index of D is {charPos}");

            // Get last name
            Console.WriteLine($"Cutting Name from Position: {charPos}");
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine($"the lastName is {lastName}");
            Console.ReadLine();
        }
        public static void Main_str_special()
        {
            string s = "It\'s \"hot\" \\ ";
            string s2 = @"It's ""hot"" \";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.ReadLine();

        }
        public static void Main_short_if()
        {
            Console.Write("Enter Hour in 24 hours Form (0:23):");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("Classic if");
            if (time < 18)
                Console.WriteLine("Good day.");
            else
                Console.WriteLine("Good evening.");

            Console.WriteLine("using result variable");
            string result = time < 18 ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            Console.WriteLine("One Line");
            Console.WriteLine(time < 18 ? "Good day." : "Good evening.");
            Console.ReadLine();
        }
        public static void Main_switch()
        {
            // int if all values are int
            string day = 4.ToString();
            day = "8";
            day = (1 + 2).ToString();
            switch (day)
            {
                case "3":
                    Console.WriteLine("Monday");
                    Console.WriteLine("Monday");
                    Console.WriteLine("Monday");
                    break;
                case "4":
                    Console.WriteLine("Tuesday");
                    break;
                case "5":
                    Console.WriteLine("Wednesday");
                    break;
                case "6":
                    Console.WriteLine("Thursday");
                    break;
                case "7":
                    Console.WriteLine("Friday");
                    break;
                case "1":
                    Console.WriteLine("Saturday");
                    break;
                case "2":
                    Console.WriteLine("Sunday");
                    break;

                case "8":
                case "9":
                default:
                    Console.WriteLine("Wrong Day");
                    return;// no break needed!
            }
            // Outputs "Thursday" (day 4)
        }
        public static void Main_while()
        {
            int i = 5;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void Main_while02()
        {

            string rightPass = "Monday";
            bool b = false;
            while (!b)
            {
                Console.Write("Enter Password :");
                string pass = Console.ReadLine();
                b = pass == rightPass;
                if (b) Console.WriteLine("Good Job!");
                else Console.WriteLine("Wrong Pass, Try Again!");
            }

        }
        public static void Main_do_while()
        {

            string rightPass = "Monday";
            bool b = false;
            do
            {
                Console.Write("Enter Password :");
                string pass = Console.ReadLine();
                b = pass == rightPass;
                if (b) Console.WriteLine("Good Job!");
                else Console.WriteLine("Wrong Pass, Try Again!");
            } while (!b);

        }

        public static void Main_for()
        {
            int n = 10, m = 3;
            // Outer loop
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= m; j++)//j+=2)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 4 times (2 * 3)
                }
            }
        }
        public static void Main_for_Nested()
        {
            int n = 10, l = 2, m = 3;
            // Outer loop
            for (int i = 1; i <= n; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes n times
                //Middle Loop
                for (int k = 1; k <= l; k++)
                {
                    Console.WriteLine(" Middle: " + k); // Executes n*k times
                    // Inner loop
                    for (int j = 1; j <= m; j++)//j+=2)
                    {
                        Console.WriteLine(" Inner: " + j); // Executes n*k*m times 
                    }
                }
            }
        }
        public static void Main_foreach()
        {
            int[] ints = { 1, 2, 4, 6, 8, 0, 11, 80, -1 };

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string str in cars)
            {
                Console.WriteLine(str);
                foreach (int i in ints)
                    Console.Write(i + ", ");
                Console.WriteLine();
            }
        }
        public static void Main_conbreak()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                if (i == 5)
                {
                    Console.WriteLine("skipping 5");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public static void Main_Array()
        {
            string[] cars1 = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };
            bool exit = false;
            do
            {
                Console.Write(@"1. Display Car List
2. Re-enter Car List
3. Re-define car List
4. Sort
5. Exit
Enter Your Choice :");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        foreach (string str in cars4)
                        {
                            Console.WriteLine(str);
                            //str = "fgfg";
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Re Enter {cars4.Length} items :-");
                        for (int i = 0; i < cars4.Length; i++)
                            cars4[i] = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine($"Re Enter number of items :");
                        int n = int.Parse(Console.ReadLine());
                        cars4 = new string[n];
                        Console.WriteLine($"Car List was reset with {n} items");
                        break;
                    case "4":
                        Array.Sort(cars4);
                        Console.WriteLine($"Car List Sorted!");
                        break;
                    case "5":
                        return;
                    default:
                        break;
                }
            } while (!exit);
        }
        public static void Main_Array02()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);
            Console.WriteLine(numbers[1, 2]);
            //Console.WriteLine(numbers[2, 2]);
        }
        public /*static*/ void Main_Array03()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine("Get all of ints using foreach");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Get all of ints using nested for");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"item[{i},{j}]={numbers[i, j]}");
                }
            }
        }
  
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */