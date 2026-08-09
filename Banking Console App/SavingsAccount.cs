public class SavingsAccount: BaseAccount, IWithdrawable
{
    public SavingsAccount(decimal InitialBalance): base(InitialBalance){ InterestRate = 0.005833M; }
    public SavingsAccount(): this(0){}
    public IWithdrawable Withdraw(decimal Amount)
    {
        if(this.balance < Amount)
        {
            throw new ArgumentException("You don't have the funds for that transaction!");
        }
        if(Amount <= 0)
        {
            throw new ArgumentException("Withdraw a positive amount!");
        }
        this.balance -= Amount;
        return this;
    }
}