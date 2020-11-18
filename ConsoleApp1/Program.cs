using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 3, 4, 5, 6 };
            string value = arr.ToString();
            string[] v1 = value.Split(value, 3);
            Console.WriteLine(v1);
        }
        static string hackerrankInString(string s)
        {
            Queue<char> sCheck = new Queue<char>();
            sCheck.Enqueue('h');
            sCheck.Enqueue('a');
            sCheck.Enqueue('c');
            sCheck.Enqueue('k');
            sCheck.Enqueue('e');
            sCheck.Enqueue('r');
            sCheck.Enqueue('r');
            sCheck.Enqueue('a');
            sCheck.Enqueue('n');
            sCheck.Enqueue('k');


            foreach (var x in s)
            {
                if (x == sCheck.Peek())
                {
                    sCheck.Dequeue();
                }
            }
            if (sCheck != null)
                return "NO";
            return "YES";
        }

        static void kaprekarNumbers(int p, int q)
        {
            for (int i = p; i < q; i++)
            {
                int count = (i * i).ToString().Length;
                if (count % 2 != 0 && i != 1)
                    continue;
                count /= 2;
                double v1 = (i * i) / Math.Pow((double)10, (double)count);
                double v2 = (i * i) % Math.Pow((double)10, (double)count);
                if ((int)v1 + (int)v2 == i)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
