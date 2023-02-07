using cSharpBank;

CheckingAccount andrewAccount = new CheckingAccount();
andrewAccount.accountHolder = "Andrew Stuart";
andrewAccount.agency = 15;
andrewAccount.account = "1010-6";
andrewAccount.balance = 100;


Console.WriteLine("Andrew balance: " + andrewAccount.balance);

andrewAccount.Deposit(100);






