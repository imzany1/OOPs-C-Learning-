public class FixedDepositAccount: BaseAccount
{
    public FixedDepositAccount(decimal InitialBalance): base(InitialBalance){ InterestRate = 0.01M; }
    public FixedDepositAccount(): base(0){}
    
}