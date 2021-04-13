using System;
using System.ComponentModel.DataAnnotations;

namespace BankSystem
{
    public abstract class Wallet
    {
        [Required]
        public Guid WalletId { get; set; }
        public abstract decimal CurrentAmount { get; set; }
        public int ApplicationUserId { get; set; }

        public Wallet(int applicationUserId, decimal amount)
        {
            WalletId = Guid.NewGuid();
            CurrentAmount = amount;
            ApplicationUserId = applicationUserId;
        }

        public abstract bool AddAmount(decimal amount);

        public abstract bool WithdrawAmount(decimal amount);
    }
}
