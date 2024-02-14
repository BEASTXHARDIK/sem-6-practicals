using System;
class Program
{
     static void Main()
    {
        int [] n1 = {10,87,32,6,25};
        int [] n2 = {5,0,0,6};
        int i;
        try 
        {
            for (i=0;i<n1.Length;i++)
            {
                try {
                        Console.WriteLine("n1="+n1[i] + "\n"+"n2="+n2[i]+ "\n"+ "Ans="+n1[i]/n2[i]);
                    }
                catch(DivideByZeroException e1)
                    {
                        Console.WriteLine("Inner catch Block");
                        Console.WriteLine("Ans="+e1.Message);
                        
                        
                    }
                
            }
        }
        catch(IndexOutOfRangeException e2)
        {
            Console.WriteLine("Outter  catch Block");
            Console.WriteLine("Ans="+e2.Message);
        }
        
    }
}
