using cSharpBank.AccountHolder;
using cSharpBank.Accounts;
using cSharpBank.Exceptions;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var fileAdress = "accounts.txt";
        var bytesRead = -1;

        var fileStream = new FileStream(fileAdress, FileMode.Open);
        var buffer = new byte[1024];
        bytesRead = fileStream.Read(buffer, 0, 1024);

        while(bytesRead != 0) 
        {
            bytesRead = fileStream.Read(buffer, 0, 1024);
            WriteBuffer(buffer);
        }
        
        fileStream.Close();
        Console.ReadLine();
    }

    static void WriteBuffer(byte[] buffer)
    {
        var utf8 = new UTF8Encoding();

        var text = utf8.GetString(buffer);
        Console.Write(text);

        //foreach (var myByte in buffer)
        //{
        //    Console.WriteLine(myByte);
        //    Console.WriteLine(" ");
        //}
    }
}













