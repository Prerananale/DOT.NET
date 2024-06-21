using System;
namespace thite{
    class Star3{
        static void Main(string[] args){
            int i,j,n;
            Console.WriteLine("Enter the number of rows:");
            n=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=n;i++){
                for(j=1;j<=n-i;j++){
                    Console.Write(" ");
                }
                
                int stars=2*i-1;

                for(j=1;j<=stars;j++){
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for(i=n;i>=1;i--){
                for(j=1;j<=n-i;j++){
                    Console.Write(" ");
                }
                
                int stars=2*i-1;

                for(j=1;j<=stars;j++){
                    Console.Write("*");
                }

                Console.WriteLine();
            }



        }
    }
}