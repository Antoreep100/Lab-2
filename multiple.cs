using System;
public interface IPrinter
{
  void Print(string Document);
}
public interface IScanner
{
  void Scan(string Document);
}
public interface ICopier
{
  void Copy(string Document);
}
public class MultiFunctionDevice:IPrinter,IScanner,ICopier
{
  public void Print(string Document)
  {
    Console.WriteLine("Printing Document:"+ Document);
  }
  public void Scan(string Document)
  {
    Console.WriteLine("Scanning Document:"+ Document);
  }
  public void Copy(string Document)
  {
    Console.WriteLine("Copying Document:"+ Document);
  }
   public class OnlyPrinterDevice:IPrinter
   {
     public void Print(string Document)
  {
    Console.WriteLine("Printing Document:"+ Document);
  }
   }
   public class ScanandCopy:IScanner,ICopier
   {
     public void Scan(string Document)
  {
    Console.WriteLine("Scanning Document:"+ Document);
  }
  public void Copy(string Document)
  {
    Console.WriteLine("Copying Document:"+ Document);
  }
   }
   class Program
   {
     static void Main()
     {
       
     }
   }
