using System;
namespace thite{
    class Poly{
        static void Main(string[] args){
            int p,s,a,f;
            Console.WriteLine("Enter the Sides:");
            s=Convert.ToInt32(Console.ReadLine());
            p=5*s;

            Console.WriteLine("Perimeter is:"+p);

            Console.WriteLine("Area of Polygonal.");
            Console.WriteLine("Enter the Apothem:");
            a=Convert.ToInt32(Console.ReadLine());
            f=p*a;


            Console.WriteLine("Area of Polygon is: "+f);
        }
    }
}