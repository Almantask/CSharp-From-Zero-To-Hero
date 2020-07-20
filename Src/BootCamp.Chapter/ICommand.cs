using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ICommand
    { 
        abstract void VerifyCommand(string inputCommand);

        void ExecuteCommand(TransactionDataParser transactionData);

        void ComputeStats();
    }
}
