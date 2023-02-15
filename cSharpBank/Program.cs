using cSharpBank.AccountHolder;
using cSharpBank.Accounts;
using cSharpBank.Exceptions;

try
{
    CheckingAccount account1 = new CheckingAccount(120, "1011-45");
    account1.Deposit(100);
    account1.Withdraw(200);
    Console.WriteLine(account1.GetBalance());
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Parameter with error: " + ex.ParamName);
}
catch (InsuficientBalanceException ex)
{
    Console.WriteLine(ex.Message);
}













