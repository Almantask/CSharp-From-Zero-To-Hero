namespace BootCamp.Chapter.Commands
{
    public interface ICommand
    { 
        void VerifyCommand(string inputCommand);

        void ExecuteCommand(TransactionDataParser transactionData);

        void ComputeStats();
    }
}
