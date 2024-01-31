using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_practicals
{
    internal class Program 
    {
        static void Main(string[] args)
        {     //Practical 14 start//
            /* int n, c = 1, blk, i, j;
             Console.Write("Enter length of pascal triangle :");
             n=Convert.ToInt32(Console.ReadLine());
             for(i=0;i<n;i++)
             {
                 for (blk = 1; blk <= n - i; blk++)
                 {
                     Console.Write(" ");
                 }
                 for (j = 0; j <= i; j++) 
                 {
                     if (j == 0 || i == 0)
                     { c = 1; }

                     else { c = c * (i - j + 1) / j; }
                     Console.Write(c + " ");
                 }
                 Console.WriteLine();
             }
            */
              //Practical 14 End//
              //PRactical 16 Start//
            Console.WriteLine(Cal.add(12, 23));
            Console.WriteLine(Cal.add (12,23,25));
            Console.WriteLine(Cal.add("Hello ","World"));
            Console.WriteLine(Cal.add(10 , "World"));
            Console.WriteLine(Cal.add("10", 15));

        }
    }
    public class Cal 
    {
        public static int add(int a, int b) 
        { return a + b; }
        public static int add(int a, int b ,int c) 
        { return a + b + c; }
        public static string add(string a, string b) 
        { return a + b; }
        public static string add(int a, string b) { return a + b; }
        public static int add(string a, int b) 
        {
            return Convert.ToInt32(a) + b;
        }
    }
}
