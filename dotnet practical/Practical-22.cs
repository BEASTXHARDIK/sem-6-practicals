using System;
class Program
{
    static void Main(){
        int i;
        int[] n1 = {113, 108, 112 ,64, 170, 83};
        int[] n2 = {5, 0, 0, 6};
        for(i=0; i<n1.Length; i++){
            try{
                Console.WriteLine("n1 = "+n1[i]);
                Console.WriteLine("n2 = "+n2[i]);
                Console.WriteLine("Ans = "+n1[i]/n2[i]);
            }
            catch(DivideByZeroException e1)
            {
                Console.WriteLine("Ans = "+ e1.Message);
            }
            catch(IndexOutOfRangeException e2){
                Console.WriteLine("Ans = "+ e2.Message);
            }
        }
    }
}
