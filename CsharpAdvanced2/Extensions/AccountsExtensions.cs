using System;
using System.Collections.Generic;

namespace BankSystem
{
    public static class AccountsExtensions
    {
        public static void ShowAllAccounts(this List<NormalAccount> walletTypes)
        {
            foreach (var account in walletTypes)
            {
                Console.WriteLine($"Id:{account.WalletId}, Amount:{account.CurrentAmount}, account type: {account.GetType().Name}, holder id:{account.ApplicationUserId}");
            }
        }
        public static void ShowAllAccounts(this List<OverdrawableAccount> walletTypes)
        {
            foreach (var account in walletTypes)
            {
                Console.WriteLine($"Id:{account.WalletId}, Amount:{account.CurrentAmount}, account type: {account.GetType().Name}, holder id:{account.ApplicationUserId}");
            }
        }
        public static void ShowAllAccounts(this LinkedAccount walletTypes)
        {
            foreach (var account in walletTypes.LinkedAccounts)
            {
                Console.WriteLine($"Id:{account.WalletId}, Amount:{account.CurrentAmount}, account type: {account.GetType().Name}, holder id:{account.ApplicationUserId}");
            }
        }
    }
}
