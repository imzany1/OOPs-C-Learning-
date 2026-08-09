public interface IAccount
{
    public decimal GetBalance();
    public IAccount Deposit(decimal Amount);
    public IAccount Interest(decimal Months);
}