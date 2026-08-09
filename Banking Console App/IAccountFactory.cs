public interface IAccountFactory
{
    BaseAccount CreateAccount(int accountType, decimal initialBalance);
}