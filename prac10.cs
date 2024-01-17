using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYHMKPROJECT
{
    internal class Myproject
    {
        static void Main(string[] args)
        {
            int k, i, number = 5,count=5,countabc=5,countdesc=0,counthybrid=5;
            for (k = 1; k <= number; k++)
            {
                
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= k ; i++)
                    Console.Write(i +" ");
                Console.WriteLine();

            }
            Console.WriteLine();
            for (k = 1; k <= number; k++)
            {
                
                for (i = 1; i <= countabc; i++)
                    Console.Write(" ");
                countabc--;
                for (i = 1; i <= k; i++)
                    Console.Write((Convert.ToChar(i + 64)) + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (k = 5; k > 0; k--)
            {
                
                for (i = 5; i > countdesc; i--)
                    Console.Write(" ");
                countdesc++;
                for (i = 5; i >= k; i--)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
            Console.WriteLine();


            for (k = 1; k <= 5; k++)
            {

                for (i = 1; i <=counthybrid; i++)
                    Console.Write(" ");
                counthybrid--;

                for (i = 1; i <= k; i++)
                    if (k % 2 != 0) { Console.Write(i + " "); }
                    else { Console.Write((Convert.ToChar(i + 64)) + " "); }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
