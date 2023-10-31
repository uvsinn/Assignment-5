using Microsoft.VisualBasic;
using System.Security.Principal;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.WriteLine("Enter account id\n");
            account.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account Type\n");
            account.AccountType = Console.ReadLine();
            Console.WriteLine("Enter accont balance\n");
            account.Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter amount to withdraw\n");
            int withdrawn_amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(account.GetDetails());
            //int id;
            //string accType;
            //double balance;
            //account.GetDetails(out id, out accType, out balance);
            //Console.WriteLine($"Account Id: {id} \n Account Type: {accType}\n Balance: {balance}");
            if (account.Withdraw(withdrawn_amount))
            {
                Console.WriteLine($"New Balance: {account.Balance - withdrawn_amount}");
                account.Balance = account.Balance - withdrawn_amount;
            }
        }
    }
}