using System;

class Program
{
    static void Main()
    {
        
        int valueType = 10;
        Console.WriteLine("Before ModifyValueType: " + valueType);
        ModifyValueType(valueType);
        Console.WriteLine("After ModifyValueType: " + valueType);
        MyClass referenceType = new MyClass();
        referenceType.Number = 10;
        Console.WriteLine("Before ModifyReferenceType: " + referenceType.Number);
        ModifyReferenceType(referenceType);
        Console.WriteLine("After ModifyReferenceType: " + referenceType.Number);
    }

    static void ModifyValueType(int num)
    {
        num = 20;
        Console.WriteLine("Inside ModifyValueType: " + num);
    }

    static void ModifyReferenceType(MyClass obj)
    {
        obj.Number = 20;
        Console.WriteLine("Inside ModifyReferenceType: " + obj.Number);
    }
}

class MyClass
{
    public int Number { get; set; }
}
