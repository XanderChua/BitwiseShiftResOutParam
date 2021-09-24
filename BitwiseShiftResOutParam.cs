using System;

namespace ShiftBitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShiftBitwiseOperator();
            //jagged_Array();
            //ref_out_param();
            //param_method();
            //out_param_modifier();
            param_method();
            doSomething(out int res, 10, 5);//array index 1 = 1, array index 2 = 5

        }



        private static void out_param_modifier()
        {
            object obj = 25;
            var boolResult = isValidInt(obj, out int res);
            Console.WriteLine(boolResult);
            Console.WriteLine(res);
            //Console.WriteLine(res1);
        }

        private static bool isValidInt1(object s, out object res, out int res1)
        {
            res1 = 10;
            res = "xxx";
            return true;

        }

        private static bool doSomething(out int res, params int[] list)
        {
            //int a = 10;
            //int b = 20;
            int a = list[0] - list[1];

            if (a > 0)
            {
                res = a;
                return true;
            }
            else
            {
                res = a;
                return false;
            }
        }

        private static bool isValidInt(object s, out int res)
        {
            if (s is int)
            {
                res = (int)s;
                return true;
            }
            res = -1;
            return false;
        }

        private static void param_method()
        {
            printparameters(1, 2, 3, 4);

            int[] intarr = new int[] { 5, 6, 7, 8, 9 };
            object[] objarr = new object[] { 5, 6, 7, 8, 9 };
            printparameters(intarr);
            printparameters1(objarr);
        }

        private static void printparameters(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"List element {i} is {list[i]}");
            }
        }

        private static void printparameters1(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"List element {i} is {list[i]}");
            }
        }

        private static void ref_out_param()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            swap(a, b);
            swapbyref(ref a, ref b);

            Console.WriteLine("After swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

        }
        //pass by reference
        private static void swapbyref(ref int c, ref int d)
        {
            int temp = c;
            c = d;
            d = temp;
        }

        //pass by value
        private static void swap(int c, int d)
        {
            int temp = c;
            c = d;
            d = temp;
        }
        private static void jagged_Array()
        {
            int[][] jaggedArr = new int[4][];
            jaggedArr[0] = new int[2] { 5, 10 };
            jaggedArr[1] = new int[] { 10, 20, 30 };
            jaggedArr[2] = new int[1] { 40 };
            jaggedArr[3] = new int[5] { 50, 60, 70, 80, 90 };

            int[][,] jaggedArr1 = new int[2][,]
            {
                new int[,] {{1,3},{5,7}},
                new int[,] {{2,4},{6,10},{11,12}}
            };

            //int[][] jaggedArr1 = new int[][]
            //{
            //    new int[]{1,2,3},
            //    new int[]{4,5,6,7}
            //};

            //for (int i = 0; i < jaggedArr.Length; i++)
            //{
            //    for(int j = 0; j < jaggedArr[i].Length; j++)
            //    {
            //        Console.WriteLine($"Jagged array element {i} {j} is {jaggedArr[i][j]}" );
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < jaggedArr1.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < jaggedArr1[i].GetLength(x); j++)
                {
                    for (int k = 0; k < jaggedArr1[j].Rank; k++)
                    {
                        Console.WriteLine($"Jagged array element {i} {j} {k} is {jaggedArr1[i][j, k]}");
                    }
                }
                x++;
                Console.WriteLine();
            }
        }
        private static void ShiftBitwiseOperator()
        {
            uint f = 5;
            //Console.WriteLine("" + Convert.ToString(f, toBase, 2));
            //Console.WriteLine("Result: " + Convert.ToString(~f, toBase, 2));
            //Bitwise operator
            uint a = 248;
            uint b = 28;

            uint oroperation = a | b;
            uint andoperation = a & b;
            uint xoroperation = a ^ b;

            Console.WriteLine("a: " + Convert.ToString(a, toBase: 2));
            Console.WriteLine("b: " + Convert.ToString(b, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(oroperation, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(andoperation, toBase: 2));
            Console.WriteLine("Result: " + Convert.ToString(xoroperation, toBase: 2));

            //Shift operator
            uint c = 10;
            uint leftshift = c << 2;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Result leftshift: " + Convert.ToString(c << i));
            }

            Console.WriteLine("c: " + Convert.ToString(c, toBase: 2));
            Console.WriteLine("Result leftshift: " + Convert.ToString(leftshift, toBase: 2));

            uint d = 1000;
            uint rightshift = d >> 2;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Result right: " + Convert.ToString(d >> i));
            }

            Console.WriteLine("d: " + Convert.ToString(d, toBase: 2));
            Console.WriteLine("Result rightshift: " + Convert.ToString(rightshift, toBase: 2));

            a = 10;
            b = 20;
            c = 30;
            d = 40;

            var res = ~d | b ^ a & c;
            var res1 = ~d;
            var res2 = a & c;
            var res3 = b ^ res2;
            var res4 = res1 | res3;

            Console.WriteLine("Result: " + res);
        }
    }
}