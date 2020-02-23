using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class PeopleAndBalanceManager
    {
        private PersonAndBalance[] _peopleAndBalances;
        private Formatter _formatter;
        public PeopleAndBalanceManager(string[] peopleAndBalances)
        {
            _peopleAndBalances = CreatePersonsArray(peopleAndBalances);
            _formatter = new Formatter();
        }

        private PersonAndBalance[] CreatePersonsArray(string[] peopleAndBalances)
        {
            _peopleAndBalances = new PersonAndBalance[peopleAndBalances.Length];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                _peopleAndBalances[i] = new PersonAndBalance(peopleAndBalances[i]);
            }
            return _peopleAndBalances;
        }

        public string FindHighestBalanceEver()
        {
            return _formatter.GetFormatedAnswerForHighestBalanceEver(_peopleAndBalances, GetHighestBalanceEver());
        }

        public float GetHighestBalanceEver()
        {
            var highestBalance = _peopleAndBalances[0].GetHighestBalance();

            for (int i = 0; i < _peopleAndBalances.Length; i++)
            {
                if (highestBalance < _peopleAndBalances[i].GetHighestBalance())
                {
                    highestBalance = _peopleAndBalances[i].GetHighestBalance();
                }
            }
            return highestBalance;
        }

    }
}
