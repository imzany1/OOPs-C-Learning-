public abstract class BaseAccount : IAccount
{
    protected decimal balance;
    private decimal interestRate;
    public BaseAccount(decimal initialBalance)
    {
        this.balance = initialBalance;
    }

    public decimal GetBalance()
    {
        return this.balance;
    }

    public IAccount Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive, got : " + amount);
        }
        this.balance += amount;
        return this;
    }
    public decimal InterestRate
    {
        get{ return interestRate;}
        set
        {
            if(value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(interestRate), "Interest Rate must be positive!");
            }
            interestRate = value;
        }
    }
    
    public IAccount Interest(decimal Months)
    {
        this.balance += this.balance * Months * interestRate;
        return this;
    }
}