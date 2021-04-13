using BankSystem;
using Dictionary;
using System;
using System.Collections.Generic;

namespace CsharpAdvanced2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new DefaultDictionary<string, int>(() => 0);

            Console.WriteLine(dictionary["thing"]);

            dictionary.TryAdd("Test1", 4);
            dictionary.TryAdd("Test1", 4);//will not be added because the key is duplicated
            dictionary.TryAdd("Test2", 4);

            dictionary.PrintDictionary();

            Console.WriteLine();
            dictionary.CountWords();

            //Part 2 bank system
            var autoIncrementId = new AutoIncrement();

            List<NormalAccount> normalAccounts = new List<NormalAccount>
            {
                new NormalAccount(autoIncrementId.GenerateId(), 55000),
                new NormalAccount(1, 55000),
                new NormalAccount(autoIncrementId.GenerateId(), -55)//return 0
            };

            List<OverdrawableAccount> overdrawableAccount = new List<OverdrawableAccount>
            {
                new OverdrawableAccount(autoIncrementId.GenerateId(), 626),
                new OverdrawableAccount(1, 7562),
                new OverdrawableAccount(autoIncrementId.GenerateId(), -55559)
            };

            LinkedAccount linkedAccount = new LinkedAccount(0, 0);
            linkedAccount.LinkedAccounts.Add(new NormalAccount(5, 4545));
            linkedAccount.LinkedAccounts.Add(new OverdrawableAccount(1, 7788));
            linkedAccount.LinkedAccounts.Add(new NormalAccount(1, 68766));

            Console.WriteLine("\nNormal accounts:");
            normalAccounts.ShowAllAccounts();

            Console.WriteLine("Overdrawable accounts:");
            overdrawableAccount.ShowAllAccounts();

            Console.WriteLine("Linked accounts:");
            linkedAccount.ShowAllAccounts();

            Console.WriteLine($"\nSupplementing the normal account with money, status: {normalAccounts[2].AddAmount(10)}, current amount: {normalAccounts[2].CurrentAmount}");
            Console.WriteLine($"Withdrawing money from the normal account, status: {normalAccounts[1].WithdrawAmount(5)}, current amount: {normalAccounts[1].CurrentAmount}");
            Console.WriteLine($"Withdrawing more money than the normal account holds, status: {normalAccounts[2].WithdrawAmount(45)}, current amount: {normalAccounts[2].CurrentAmount}");

            Console.WriteLine($"\nSupplementing the overdrawable account with money, status: {overdrawableAccount[2].AddAmount(1010)}, current amount: {overdrawableAccount[2].CurrentAmount}");
            Console.WriteLine($"Withdrawing money from the overdrawable account, status: {overdrawableAccount[2].WithdrawAmount(1010)}, current amount: {overdrawableAccount[2].CurrentAmount}");

            Console.WriteLine($"\nSupplementing the linked account with money, status: {linkedAccount.LinkedAccounts[1].AddAmount(10)}, current amount: {linkedAccount.LinkedAccounts[1].CurrentAmount}");
            Console.WriteLine($"\nWithdrawing money from linked account, status: {linkedAccount.LinkedAccounts[1].WithdrawAmount(2)}, current amount: {linkedAccount.LinkedAccounts[1].CurrentAmount}");
        }
    }
}
