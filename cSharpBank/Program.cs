using cSharpBank.AccountHolder;
using cSharpBank.Accounts;
using cSharpBank.Exceptions;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var fileAdress = "accounts.txt";

        using(var fileStream = new FileStream(fileAdress, FileMode.Open))
        {
            var bytesRead = -1;


            var buffer = new byte[1024];
            bytesRead = fileStream.Read(buffer, 0, 1024);

            while (bytesRead != 0)
            {
                bytesRead = fileStream.Read(buffer, 0, 1024);
                WriteBuffer(buffer, bytesRead);
            }

            fileStream.Close();
            Console.ReadLine();
        }
        
    }

    static void WriteBuffer(byte[] buffer, int bytesRead)
    {
        var utf8 = new UTF8Encoding();

        var text = utf8.GetString(buffer, 0, bytesRead);
        Console.Write(text);

        //foreach (var myByte in buffer)
        //{
        //    Console.WriteLine(myByte);
        //    Console.WriteLine(" ");
        //}
    }
}













