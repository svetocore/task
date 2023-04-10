using System;
using System.Collections.Generic;
using System.Net.Http;

namespace task1
{
    internal class Program
    {
        public 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность болтов");
            List<int> four1 = new List<int> { 0, 1, 2, 3 };
            List<int> four2 = new List<int> { 4, 5, 6, 7 };

            for (int i = 0; i < 2; i++)
            {
                int n1 = Convert.ToInt32(Console.ReadLine());

                if ((n1 < 4) && four1.Count == 4 && n1 % 2 == 0)
                {
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 != n1 + 1) Console.WriteLine("Ошибка");
                    four1.Remove(n1);
                    four1.Remove(n2);
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    if (four1.Contains(n3)) four1.Remove(n3);
                    else Console.WriteLine("Ошибка");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    if (!four1.Contains(n4)) Console.WriteLine("Ошибка");
                }
                if ((n1 < 4) && four1.Count == 4 && n1 % 2 == 1)
                {
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 != n1 - 1) Console.WriteLine("Ошибка");
                    four1.Remove(n1);
                    four1.Remove(n2);
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    if (four1.Contains(n3)) four1.Remove(n3);
                    else Console.WriteLine("Ошибка");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    if (!four1.Contains(n4)) Console.WriteLine("Ошибка");
                }



                if ((n1 > 3) && four2.Count == 4 && n1 % 2 == 0)
                {
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 != n1 + 1) Console.WriteLine("Ошибка");
                    four2.Remove(n1);
                    four2.Remove(n2);
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    if (four2.Contains(n3)) four2.Remove(n3);
                    else Console.WriteLine("Ошибка");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    if (!four2.Contains(n4)) Console.WriteLine("Ошибка");
                }

                if ((n1 > 3) && four2.Count == 4 && n1 % 2 == 1)
                {
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    if (n2 != n1 - 1) Console.WriteLine("Ошибка");
                    four2.Remove(n1);
                    four2.Remove(n2);
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    if (four2.Contains(n3)) four2.Remove(n3);
                    else Console.WriteLine("Ошибка");
                    int n4 = Convert.ToInt32(Console.ReadLine());
                    if (!four2.Contains(n4)) Console.WriteLine("Ошибка");
                }
            }
        }
    }
}
