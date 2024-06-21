using System;
namespace thite
{
    class Star2{
        static void Main(string[] args){
            int i,j,n,k;
            Console.WriteLine("Enter the rows:");
            n=Convert.ToInt32(Console.ReadLine());

            for (i =n; i>=1; i--) { 
  
                for (j = 0; j <n -i; j++) 
                { 
                Console.Write(" "); 
                } 
                for (k = 0; k < i ; k++)
                 {
                Console.Write("* "); 
                } 


            Console.WriteLine();         
        }
    }
}
}