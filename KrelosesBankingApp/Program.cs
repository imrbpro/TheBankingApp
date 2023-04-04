using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrelosesBankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Account = new BankAccount();

            Console.WriteLine("Kreloses Banking System");
            Console.WriteLine("Enter D to Deposit Amount, W to withdraw Amount and B to get Account Balance. \n Or Enter Q to Exit");

            while (true)
            {
                string choice = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choice))
                {
                    continue;
                }
                if(choice.ToUpper() == "Q")
                {
                    break;
                }
                if(choice.ToUpper() == "D")
                {
                    Console.Write("Enter Amount to be Deposited");
                    decimal depositAmount;
                    if(decimal.TryParse(Console.ReadLine(), out depositAmount))
                    {
                        Account.DepositAmount(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Request");
                    }
                }
                if(choice.ToUpper() == "W")
                {
                    Console.WriteLine("Enter Amount to be withdrawn");
                    decimal withdrawAmount;
                    if(decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                    {
                        Account.WithDrawAmount(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Request");
                    }
                }
                if(choice.ToUpper() == "B")
                {
                    Console.WriteLine("Current Account Balance is : " + Account.BankBalance);
                }

            }

        }
    }
}
