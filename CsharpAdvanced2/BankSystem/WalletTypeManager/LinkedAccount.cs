using System.Collections.Generic;
using System.Linq;

namespace BankSystem
{
    public class LinkedAccount : Wallet
    {
        public List<Wallet> LinkedAccounts { get; set; }

        public override decimal CurrentAmount { get => LinkedAccounts.Sum(i => i.CurrentAmount); set { } }

        public LinkedAccount(int applicationUserId, decimal amount) : base(applicationUserId, amount)
        {
            LinkedAccounts = new List<Wallet>();
        }

        public override bool AddAmount(decimal amount)
        {
            if (amount > 0)
            {
                LinkedAccounts.OrderBy(i => i.CurrentAmount).FirstOrDefault().CurrentAmount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool WithdrawAmount(decimal amount)
        {
            foreach (var _ in from currentAccount in LinkedAccounts.OrderByDescending(i => i.CurrentAmount)
                              where currentAccount.WithdrawAmount(amount)
                              select new { })
            {
                return true;
            }

            return false;
        }
    }
}