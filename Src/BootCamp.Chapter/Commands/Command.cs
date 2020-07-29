using System.Collections;

namespace BootCamp.Chapter.Commands
{
    public abstract class Command
    {
        public IDictionary ResultsOfCommand { get; set; }

        public string HeadingOfFile;

        public string NameOfOutputFile;

        public abstract void VerifyCommand(string inputCommand);
        
        public abstract  void ExecuteCommand(TransactionDataParser transactionData);

        public abstract  void ComputeStats();
    }
}
