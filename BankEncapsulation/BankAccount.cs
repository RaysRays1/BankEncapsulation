using System.IO.Compression;

namespace BankEncapsulationCSharp_50;



public class BankAccount
{
    
    //Fields
    public string name;
    private int age;
    
    
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    
    //Fields
    private double _balance;
    
    //Methods (public) can access the private fields

    public void AddMoney(double moneyToAdd)
    {
        _balance += moneyToAdd;
    }

    public double CheckBlance()
    {
        return _balance;
    }
    
    
    
       






    

}
