public class FixedDepositAccount: BaseAccount
{
    public FixedDepositAccount(decimal InitialBalance): base(InitialBalance){ InterestRate = 0.02M; }
    public FixedDepositAccount(): base(0){}
    
}