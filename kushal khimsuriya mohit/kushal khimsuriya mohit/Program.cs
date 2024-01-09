using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A Number : ");
            int num=Convert.ToInt32(Console.ReadLine()); 
            int factorial(int nums) 
            {
                int fact = 1;
                for (int i = 2; i <= nums; i++) 
                {
                    fact*=i;
                }
                return fact;
            }
            Console.WriteLine(factorial(num) + " is factorial of " + num);
            
            Console.Write("Enter a number to start febo series : ");
            num= Convert.ToInt32(Console.ReadLine());
            
            int febo(int nums) 
            {
                int feb=0 ,num1 = 0 ,num2=1;
                for (int i = 1;i <= nums;i++) 
                {
                    feb = num1 + num2 ;
                    num1 = num2;
                    num2 = feb;
                    Console.WriteLine(feb+ "is current value ");
                }
                return feb;
            }

            Console.WriteLine(febo(num) + " is answer for febo till " + num + " itrations");
        }
    }      
}
