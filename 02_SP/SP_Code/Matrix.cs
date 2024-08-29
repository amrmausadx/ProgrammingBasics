using System;

namespace ProgrammingBasics_SP
{
    internal class Matrix
    {
        public static void Matrix_Main()
        {
            int[,] x = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            int[,] y = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            //int[,] xPlusy = new int[4, 4], xTimesy = new int[4, 4];

            //PrintMatrix(x);
            //PrintMatrix (y);
            //int[,] test = EnterMatrix();
            //PrintMatrix(x);
            //PrintMatrixTri(x);
            Console.WriteLine("print x"); PrintMatrix(x);
            Console.WriteLine("print y"); PrintMatrix(y);
            Console.WriteLine("print x+y"); PrintMatrix(Add(x, y));
            Console.WriteLine("print x*y"); PrintMatrix(Mul(x, y));
            Console.WriteLine("print x-y"); PrintMatrix(Sub(x, y));
            Console.WriteLine("print (x+y)*10"); 
            PrintMatrix(MultScalar(Add(x, y),10));
        }
public static void Matrix_Main_Det()
        {
            int[,] x = { { 1, 2, 3, 4 },
                         { 5, 6, 7, 8 }, 
                         { 9, 10, 11, 12 }, 
                         { 13, 14, 15, 16 } };

            Console.WriteLine($"x[,]");
            PrintMatrix(x);

            Console.WriteLine($"Disassembling");
            for (int i = 0; i < 4; i++)
            {
                int sign = i % 2==1 ? -1 : 1;
                Console.WriteLine($"Multiplied b {sign * x[i,0]}");
                Console.WriteLine($"Printing without {i+1},{1}");
                PrintMatrix(Customize(x, i, 0));
            }
        }
        public static void PrintMatrix(int[,] Mat)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                    Console.Write(Mat[i, j] + "\t");

                Console.WriteLine();
             }
        }
        public static void PrintMatrixTri(int[,] Mat)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
            {
                for (int j = 0; j < Mat.GetLength(1); j++)
                    if (i >= j)
                        Console.Write(Mat[i, j] + "\t");
                    else
                        Console.Write("\t");
                Console.WriteLine();
            }
        }
        public static int[,] MultScalar(int[,] Mat, int scalar)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
                for (int j = 0; j < Mat.GetLength(1); j++)
                    Mat[i, j] *= scalar;

          
            return Mat;
        }
        public static int[,] MultDiaScalar(int[,] Mat, int scalar)
        {
            for (int i = 0; i < Mat.GetLength(0); i++)
                for (int j = 0; j < Mat.GetLength(1); j++)
                    if (i == j) 
                        Mat[i, j] *= scalar;

            return Mat;
        }
        public static int[,] EnterMatrix()
        {
            Console.Write("Enter No. of rows :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter No. of cols :");
            int m = int.Parse(Console.ReadLine());
            int[,] res = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Enter item[{i + 1},{j + 1}]:");
                    res[i, j] = int.Parse(Console.ReadLine());
                }

            return res;
        }
        public static int[,] Add(int[,] x, int[,] y)
        {
            if(x.GetLength(0)!= y.GetLength(0)||
               x.GetLength(1) != y.GetLength(01))
            {
                Console.WriteLine("Wrong Dim::Matrix.Add()");
                return x;
            }
            int[,] Mat = new int[x.GetLength(0), y.GetLength(1)];
            for (int i = 0; i < Mat.GetLength(0); i++)
                for (int j = 0; j < Mat.GetLength(1); j++)
                    Mat[i, j]= x[i, j] + y[i, j];


            return Mat;
        }
        public static int[,] Sub(int[,] x, int[,] y)
        {
            if (x.GetLength(0) != y.GetLength(0) ||
               x.GetLength(1) != y.GetLength(01))
            {
                Console.WriteLine("Wrong Dim::Matrix.Sub()");
                return x;
            }
            int[,] Mat = new int[x.GetLength(0), y.GetLength(1)];
            for (int i = 0; i < Mat.GetLength(0); i++)
                for (int j = 0; j < Mat.GetLength(1); j++)
                    Mat[i, j] = x[i, j] - y[i, j];


            return Mat;
        }
        public static int[,] Mul(int[,] x, int[,] y)
        {
            if (x.GetLength(1) != y.GetLength(0))
            {
                Console.WriteLine("Wrong Dim::Matrix.Mul()");
                return x;
            }
            int[,] Mat = new int[x.GetLength(0), y.GetLength(1)];
            for (int i = 0; i < Mat.GetLength(0); i++)
                for (int j = 0; j < Mat.GetLength(1); j++)
                {
                    for (int k = 0;k< x.GetLength(1); k++)
                    Mat[i, j] += x[i, k] * y[k, j];
                }

            return Mat;
        }
        public static int Det(int[,] x)
        {
            int ret = 0;
            if(x.GetLength(0)!=x.GetLength(1))
            {
                Console.WriteLine("Wron Dim ::Matrix.Det()");
                return ret;
            }
            if(x.GetLength(0)==2)
                return x[0, 0] * x[1, 1] - x[0, 1] * x[1, 0];
            else
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    int sign = i % 2 == 1 ? -1 : 1;
                    ret += sign * x[i, 0] * Det(Customize(x, i, 0));
                }
                return ret;
            }
        }
        public static int[,] Customize(int[,] x,int DelRow,int DelCol)
        {
            int n = x.GetLength(0), m = x.GetLength(0),
                nw_i=0,nw_j=0;
            int[,] nw = new int[ m- 1, m - 1];
            for(int i=0;i<n;i++)
            {
                if (i == DelRow) continue;
                nw_j = 0;
                for(int j=0;j<m;j++)
                {
                    if (j == DelCol) continue;
                    nw[nw_i, nw_j] = x[i, j];
                    nw_j++;
                }
                nw_i++;
            }
            return nw;
        }
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */