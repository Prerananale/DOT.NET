using System;

class Program
{
    static void Main()
    {
      
        int valueType = 123;      
        object boxedValue = valueType;  

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

       
        object obj = 456;        
        int unboxedValue = (int)obj; 

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

       
        double doubleValue = 78.9; 
        object boxedDouble = doubleValue; 

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; 

        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
    }
}