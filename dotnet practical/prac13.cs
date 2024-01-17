using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT
{
    internal class prac13
    {

        static void Main(string[] args)
        {
            int num, opt;

            Console.Write("\n\n");
            Console.WriteLine("A menu dirven program for a number system");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1-Binray to Decimal . \n2-Decimal to Binary .\n3-Exit . \n");
            Console.Write("Enter the number : ");
            opt=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number : ");
            num=Convert.ToInt32(Console.ReadLine());
            switch (opt) 
            {
                case 1:
                    int decimalValue =Convert.ToInt32(num.ToString(),2);
                    Console.WriteLine($"Deciamal Value : {decimalValue}");
                    break;
                case 2:
                    string Result =string.Empty;
                    for (int i = 0; num > 0; i++) 
                    {
                        Result = num % 2 + Result;
                        num=num / 2;
                    }
                    Console.WriteLine($"Binary Representation of the given Number :{Result}");
                    break;
                case 3:
                    break;
                default: Console.Write("Input correct option \n ");
                    break;

            }
         
        }

    }
}
