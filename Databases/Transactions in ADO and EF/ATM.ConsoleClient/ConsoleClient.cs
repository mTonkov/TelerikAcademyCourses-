using ATM.Data;
using ATM.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ATM.ConsoleClient
{
    public class ConsoleClient
    {
        static void Main(string[] args)
        {
            var atmDb = new ATMContext();

            //var account = new CardAccounts
            //{
            //    CardCash = 1000,
            //    CardPIN = "1234",
            //    CardNumber = "0123456789"
            //};

            //atmDb.CardAccounts.Add(account);

            //var secondAccount = new CardAccounts
            //{
            //    CardCash = 1500,
            //    CardPIN = "5678",
            //    CardNumber = "9876543210"
            //};

            //atmDb.CardAccounts.Add(secondAccount);

            //atmDb.SaveChanges();

            var accounts = atmDb.CardAccounts;
            foreach (var accnt in accounts)
            {
                Console.WriteLine(accnt.Id + ": " + accnt.CardNumber + ": " + accnt.CardCash + " BGN");
            }



            //Task 02
            Console.WriteLine("Please, identify yourself by providing your card number!");
            var accountId = Console.ReadLine();

            Console.WriteLine("Please, insert the amount that you would like to withdraw");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please, confirm that you are the owner of account " + accountId + " by providing PIN");
            string accountPin = Console.ReadLine();

            using (TransactionScope tran = new TransactionScope())
            {
                try
                {
                    var checkedAccount = atmDb.CardAccounts.Where(a => a.CardNumber == accountId &&
                                                                       a.CardPIN == accountPin).ToList();

                    if (checkedAccount.Count == 0)
                    {
                        Console.WriteLine("Sorry, Identification failed!");
                        return;
                    }

                    if (checkedAccount[0].CardCash < withdrawalAmount)
                    {
                        Console.WriteLine("You don't have enough money!");
                        return;
                    }

                    checkedAccount[0].CardCash -= withdrawalAmount;
                    atmDb.SaveChanges();

                    atmDb.TransactionsHistory.Add(new TransactionsHistory
                                                      {
                                                          CardNumber = accountId,
                                                          TransactionDate = DateTime.Now.Date,
                                                          Amount = withdrawalAmount
                                                      });
                    atmDb.SaveChanges();

                    Console.WriteLine("Please take your money ({0} BGN)", withdrawalAmount);
                    tran.Complete();
                }
                catch (Exception)
                {
                    Console.WriteLine(
                        "Sorry, Transaction failed for some reason, but your money is safe with us. " +
                        "If the problem persists, you may get your service from the nearest office! ");
                }
            }
        }
    }
}
