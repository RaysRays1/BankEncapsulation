using BankEncapsulationCSharp_50;

var rayAccount = new BankAccount();

var currentBlance = rayAccount.CheckBlance();

Console.WriteLine(currentBlance);

rayAccount.AddMoney(2300.72);

currentBlance = rayAccount.CheckBlance();

Console.WriteLine(currentBlance);

rayAccount.UserInput();







    
    
