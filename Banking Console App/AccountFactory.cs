public class AccountFactory: IAccountFactory
{
    public BaseAccount CreateAccount(int accountType, decimal initialBalance)
    {
        switch (accountType)
        {
            case 1:
            return new SavingsAccount(initialBalance);
            case 2:
            return new FixedDepositAccount(initialBalance);
            default:
            throw new ArgumentOutOfRangeException(nameof(accountType), "Invalid Account Type");
        }

    }
}