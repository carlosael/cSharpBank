using cSharpBank.AccountHolder;
using cSharpBank.Accounts;
using cSharpBank.Exceptions;
using System.IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var fileAdress = "accounts.txt";

        using(var fileStream = new FileStream(fileAdress, FileMode.Open))
        {
            var reader = new StreamReader(fileStream);

            while (!reader.EndOfStream)
            {
                var text = reader.ReadLine();
                var checkingAccount = ConvertStringToCheckingAccount(text);

                var message = $" === ACCOUNT DATA === \n" +
                            $"Account number : {checkingAccount.Account} \n" +
                            $"Agency : {checkingAccount.Agency} \n" +
                            $"Account holder: {checkingAccount.AccountHolder.Name} \n" +
                            $"Balance: {checkingAccount.GetBalance()} \n";
                Console.WriteLine(message);

            }

        }
        CreatingCsvFileWithWriter();
        //CreatingCsvFile();
        Console.WriteLine();
    }

    static void CreatingCsvFile()
    {
        var newFileAdress = "exportedAccounts.csv";

        using (var fileStream = new FileStream(newFileAdress, FileMode.Create))
        {
            var accountAsString = "account";

            var enconding = Encoding.UTF8;

            var bytes = enconding.GetBytes(accountAsString);

            fileStream.Write(bytes, 0, bytes.Length);

        }
        Console.WriteLine();


    }

    static void CreatingCsvFileWithWriter()
    {
        var newFileAdress = "exportedAccounts.csv";

        using (var fileStream = new FileStream(newFileAdress, FileMode.Create))
        using (var writer = new StreamWriter(fileStream))
        {
            writer.Write("account2");
        }
        Console.WriteLine();


    }

    static CheckingAccount ConvertStringToCheckingAccount(string lineRead)
    {
        var fields = lineRead.Split(',');
        var agency = fields[0];
        var account = fields[1];
        var balance = fields[2].Replace('.', ',');
        var accountHolderName = fields[3];

        var agencyToInt = int.Parse(agency);
        var balanceToInt = double.Parse(balance);

        var accountHolder = new Client();
        accountHolder.Name = accountHolderName;

        var result = new CheckingAccount(agencyToInt, account);
        result.Deposit(balanceToInt);
        result.AccountHolder = accountHolder;

        return result;
    }
}














