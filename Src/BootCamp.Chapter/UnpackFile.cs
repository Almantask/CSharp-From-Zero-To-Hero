using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    class UnpackFile
    {
        private List<AccountDetails> namesOfAccounts;
      
        public UnpackFile()
        {
            namesOfAccounts = new List<AccountDetails>();
            OpenFile();

        }

        private void OpenFile()
        {
            string path = @"..\..\..\Input\Balances.clean";
            using (var reader = File.OpenText(path))
            {
                var line = reader.ReadLine();
                while(line != null)
                {
                    var numOfElements = line.Split(',').Count();
                    AccountDetails accountName = new AccountDetails($"{line.Split(',')[0]}");
                    namesOfAccounts.Add(accountName);
                    for (int i = 1; i < numOfElements; i++)
                    {
                        var curBalance = line.Split(',')[i];
                        if (curBalance[0] == '-')
                        {
                            curBalance = line.Split(',')[i].Trim('-', '£');
                            accountName.AddBalance(-double.Parse(curBalance));
                        }
                        else
                        {
                            curBalance = line.Split(',')[i].Trim('£');
                            accountName.AddBalance(double.Parse(curBalance));
                        }
                        
                    }
                    line = reader.ReadLine();
                }
            }
        }

        public List<AccountDetails> ReturnAccounts()
        {
            return namesOfAccounts;
        }
    }
}
