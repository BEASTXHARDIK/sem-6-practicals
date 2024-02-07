using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace dotnetprac
{
    /*
    class calculator 
    {
        public int number = 0;
        public calculator() 
        {                                                                                                           }
        public calculator(int n) 
        {
            number = n;
        }
        public static calculator operator + (calculator obj1, calculator obj2)
        {
            calculator obj3 = new calculator();
            obj3.number = obj1.number+obj2.number;
            return obj3;
        }
        public void display()
        {
            Console.WriteLine("{0}",number);
        }
    */
    
          public class Dada 
            {
             protected void Jamin()
                {
                    Console.WriteLine("DADA Ni Jamin");
                }
            }
            public class Papa : Dada
            {
             protected   void paisa() 
                {
                    Console.WriteLine("Pappa  na Paisa");
                }
            }
            public class Son : Papa 
            {
                protected void nalyak() 
                {
                    Console.WriteLine("nalayk");
                }
            }
      internal class Program
    {
      public static void Main(string[] args)
        {/*
            calculator obj1= new calculator(200);
            calculator obj2 = new calculator(40);
            calculator obj3 = new calculator();
            obj3 = obj1 + obj2;
            obj1.display();
            obj2.display();
            obj3.display();
        */
            Son son = new Son();
            son.Jamin();
            son.paisa();
            son.nalyak();
        }
    }
}
