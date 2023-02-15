using cSharpBank.AccountHolder;
using cSharpBank.Accounts;

try
{
    CheckingAccount account1 = new CheckingAccount(0, "1011-45");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Parameter with error: " + ex.ParamName);
}













