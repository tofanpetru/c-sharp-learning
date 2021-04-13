namespace BankSystem
{
    public class OverdrawableAccount : Wallet
    {
        public override decimal CurrentAmount { get; set; }
        public OverdrawableAccount(int applicationUserId, decimal amount) : base(applicationUserId, amount)
        {

        }

        public override bool AddAmount(decimal amount)
        {
            if (amount > 0)
            {
                this.CurrentAmount += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool WithdrawAmount(decimal amount)
        {
            this.CurrentAmount -= amount;
            return true;
        }
    }
}
