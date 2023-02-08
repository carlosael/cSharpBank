using cSharpBank.AccountHolder;
using cSharpBank.Accounts;

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

//Client client = new Client();
//client.name = "Andrew Stuart";
//client.profession = "Engineer";
//client.cpf = "09988998998";

//CheckingAccount account = new CheckingAccount();
//account.accountHolder = client;
//account.agency = 15;
//account.account = "1010-6";
//account.balance = 100;

//Console.WriteLine("Account Holder: " + account.accountHolder.name);



//CheckingAccount account2 = new CheckingAccount();
//account2.accountHolder = new Client();
//account2.accountHolder.name = "Joseph Climber";
//account2.accountHolder.profession = "Analist";
//account2.accountHolder.cpf = "05532223235";
//account2.agency = 12;
//account2.account = "1010-1";
//account2.balance = 500;

//Console.WriteLine("Account Holder: " + account2.accountHolder.name);

//CheckingAccount account3 = new CheckingAccount();
//account3.Agency = 18;
//account3.SetBalance(150);
//Console.WriteLine(account3.GetBalance());
//Console.WriteLine(account3.Agency);

CheckingAccount account4 = new CheckingAccount(16, "1012-45");
account4.SetBalance(500);
account4.AccountHolder = new Client();










