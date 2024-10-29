using System;
public class BankAccount
{
  public string Name;
  public double Balance;
  private double AccountNo;
  public BankAccount(string _name,double _balance, double _acc)
  {
    Name=_name;
    Balance=_balance;
    AccountNo=_acc;
  }
  public double accountno
  {
    get{return AccountNo;}
    set{AccountNo=value;}
  }
  public void Print()
  {
    Console.WriteLine("Acc Name:"+ Name);
     Console.WriteLine("Acc Balance:$"+ Balance);
      Console.WriteLine("Acc No:"+ accountno);
  }
  static void Main()
  {
    BankAccount b1=new BankAccount("Antoreep", 1000,12345678);
  b1.Print();
   BankAccount b2=new BankAccount("Lam", 500,43259623);
  BankAccount b3=new BankAccount("Struty", 5000,23456543);
    b3.Print();
     BankAccount b4=new BankAccount("Utso", 00, 68790459);
  }
}
