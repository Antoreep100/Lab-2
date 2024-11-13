using System;
class OuterClass 
{
    private class Base
    {
        public int i,j;
    
    }
    private class Derived:Base
    {
        public int k;
        
    }
    public void Print()
    {
        Derived obj=new Derived();
        obj.i=10;
        obj.j=20;
        obj.k=30;
        Console.WriteLine(obj.i+""+obj.j+""+obj.k);
    }
}
class Program
{
    static void Main()
    {
        OuterClass outer=new OuterClass();
        outer.Print();
    }
}
