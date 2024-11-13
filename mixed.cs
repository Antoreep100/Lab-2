using System;

    public class Base
    {
        public int publicValue = 10;
        private int privateValue = 20;
        protected int protectedValue = 30;

        public void Print()
        {
            Console.WriteLine("Base public value: " + publicValue);
            Console.WriteLine("Base private value: " + privateValue);  // Accessible within the Base class
            Console.WriteLine("Base protected value: " + protectedValue);  // Accessible within Base class
        }
    }


public class Derived :Base  // Inherit from OuterClass.Base
{
    public void Print()
    {
        Console.WriteLine("Derived public value: " + publicValue);
       // Console.WriteLine("Derived private value: " + privateValue);  
        Console.WriteLine("Derived protected value: " + protectedValue);  // Accessible because 'protected' is inherited
    }
}

class Program
{
    static void Main()
    {
        Derived obj = new Derived();
        obj.Print();
    }
}
