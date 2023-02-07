using cSharpBank;

//CheckingAccount andrewAccount = new CheckingAccount();
//andrewAccount.accountHolder = "Andrew Stuart";
//andrewAccount.agency = 15;
//andrewAccount.account = "1010-6";
//andrewAccount.balance = 100;


//Console.WriteLine("Andrew balance: " + andrewAccount.balance);

//andrewAccount.Deposit(100);

//CheckingAccount maryAccount = new CheckingAccount();
//maryAccount.accountHolder = "Mary Lenon";
//maryAccount.agency = 17;
//maryAccount.account = "1010-8";
//maryAccount.balance = 350;

//Console.WriteLine("Mary balance: " + maryAccount.balance);

//andrewAccount.Transfer(50, maryAccount);

//Console.WriteLine("Andrew balance: " + andrewAccount.balance);
//Console.WriteLine("Mary balance: " + maryAccount.balance);

Client client = new Client();
client.name = "Andrew Stuart";
client.profession = "Engineer";
client.cpf = "09988998998";

CheckingAccount account = new CheckingAccount();
account.accountHolder = client;
account.agency = 15;
account.account = "1010-6";
account.balance = 100;

Console.WriteLine("Account Holder: " + account.accountHolder.name);










