using Delegate;
using System.Collections;

Account account = new Account(200);
account.RegisterHandler(PrintSimpleMessage);

account.Add(100);
account.Take(550);

Console.WriteLine($"Your balance after transaction is {account.Result()}");


NoParameters noPrmt = new(ShowMessage);
noPrmt += SendEmail;
noPrmt();


void PrintSimpleMessage(string message) => Console.WriteLine(message);
void ShowMessage() => Console.WriteLine("Thanks for transaction");
void SendEmail() => Console.WriteLine("Confirmation sent on your email");


var accounts = new List<string>() {"Checking", "Checking Premium", "Saving", "Investing", "Investing2" };
accounts.Add("Inv3");

var selectAccount = accounts.Where(a => a.ToUpper().StartsWith("C")).
    OrderBy(a => a);

Console.WriteLine("This checking accounts are available: ");

foreach (var acc in selectAccount)
{
    Console.WriteLine(acc);
}



Console.ReadKey();