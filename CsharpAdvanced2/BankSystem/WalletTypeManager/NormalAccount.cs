namespace BankSystem
{
    public class NormalAccount : Wallet
    {
        public override decimal CurrentAmount { get; set; }
        public NormalAccount(int applicationUserId, decimal amount) : base(applicationUserId, amount >= 0 ? amount : 0)
        {

        }

        public override bool WithdrawAmount(decimal amount)
        {
            if (CurrentAmount - amount >= 0)
            {
                this.CurrentAmount -= amount;
                return true;
            }
            else
            {
                return false;
            }
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
    }
}
