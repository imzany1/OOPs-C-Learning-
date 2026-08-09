public class MyBank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What type of account? Enter 1 for Savings, 2 for Fixed Deposit");
        int accountType = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter initial deposit amount: ");
        decimal initialBalance = decimal.Parse(Console.ReadLine()!);

        BaseAccount Hussain = (accountType == 1) ? new SavingsAccount(initialBalance) : new FixedDepositAccount(initialBalance);

        Console.WriteLine("Input 1 to Check Account Balance \nInput 2 to deposit cash \nInput 3 to withdraw cash. \nInput 4 to check after some months(Interest)");
        int choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                Console.WriteLine(Hussain.GetBalance());
                break;
            case 2:
                Console.WriteLine("Enter the amount you want to deposit: ");
                decimal amount = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine(Hussain.Deposit(amount).GetBalance());
                break;
            case 3:
                if (Hussain is IWithdrawable withdrawable)
                {
                    Console.WriteLine("Enter the amount you want to withdraw: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine(withdrawable.Withdraw(withdrawAmount).GetBalance());
                }
                else
                {
                    Console.WriteLine("Withdrawals not allowed on this account type!");
                }
                break;
            case 4:
                Console.WriteLine("How many months later are you checking?");
                decimal Months = decimal.Parse(Console.ReadLine()!);
                Console.WriteLine(Hussain.Interest(Months).GetBalance());
                break;
            default:
                Console.WriteLine("Please look at the menu!");
                break;
        }
    }
}