using cSharpBank;

CheckingAccount andrewAccount = new CheckingAccount();
andrewAccount.accountHolder = "Andrew Stuart";
andrewAccount.agency = 15;
andrewAccount.account = "1010-6";
andrewAccount.balance = 100;


Console.WriteLine("Andrew balance: " + andrewAccount.balance);

andrewAccount.Deposit(100);

CheckingAccount maryAccount = new CheckingAccount();
maryAccount.accountHolder = "Mary Lenon";
maryAccount.agency = 17;
maryAccount.account = "1010-8";
maryAccount.balance = 350;

Console.WriteLine("Mary balance: " + maryAccount.balance);

andrewAccount.Transfer(50, maryAccount);

Console.WriteLine("Andrew balance: " + andrewAccount.balance);
Console.WriteLine("Mary balance: " + maryAccount.balance);










