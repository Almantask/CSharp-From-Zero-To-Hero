using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class PeopleAndBalanceManager
    {
        private PersonAndBalance[] _peopleAndBalances;
        private AnswerFormatter _answerFormatter;
        public PeopleAndBalanceManager(string[] peopleAndBalances)
        {
            _peopleAndBalances = CreatePersonsArray(peopleAndBalances);
            _answerFormatter = new AnswerFormatter();
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
        public string GetHighestBalanceEverAnswer()
        {
            return _answerFormatter.GetFormattedAnswerForHighestBalanceEver(_peopleAndBalances, FindHighestBalanceEver());
        }

        public string GetPersonWithBiggestLossAnswer()
        {
            if (!isValidForCheck())
            {
                return "N/A.";
            }
            return _answerFormatter.GetFormattedAnswerForPersonWithBiggestLoss(FindPersonWithBiggestLoss());
        }

        public string GetRichestPersonAnswer()
        {
            var richestPersonsBalance = FindRichestPerson().GetCurrentBalance();
            return _answerFormatter.GetFormattedAnswerForRichestPerson(_peopleAndBalances, richestPersonsBalance);
        }

        public string GetPoorestPersonAnswer()
        {
            var poorestPersonsBalance = FindPoorestPerson().GetCurrentBalance();
            return _answerFormatter.GetFormattedAnswerForPoorestPerson(_peopleAndBalances, poorestPersonsBalance);
        }

        public bool isValidForCheck()
        {
            for (int i = 0; i < _peopleAndBalances.Length; i++)
            {
                if (_peopleAndBalances[i].GetBalanceHistory().Length < 2)
                {
                    return false;
                }
            }
            return true;
        }

        private PersonAndBalance FindPoorestPerson()
        {
            if (_peopleAndBalances.Length == 1)
            {
                return _peopleAndBalances[0];
            }
            var poorestPerson = _peopleAndBalances[0];
            for (int i = 0; i < _peopleAndBalances.Length - 1; i++)
            {
                if (poorestPerson.GetCurrentBalance() > _peopleAndBalances[i + 1].GetCurrentBalance())
                {
                    poorestPerson = _peopleAndBalances[i + 1];
                }
            }
            return poorestPerson;
        }

        private PersonAndBalance FindRichestPerson()
        {
            if(_peopleAndBalances.Length == 1)
            {
                return _peopleAndBalances[0];
            }

            var richestPerson = _peopleAndBalances[0];
            for (int i = 0; i < _peopleAndBalances.Length - 1; i++)
            {
                if(richestPerson.GetCurrentBalance() < _peopleAndBalances[i + 1].GetCurrentBalance())
                {
                    richestPerson = _peopleAndBalances[i + 1];
                }
            }
            return richestPerson;
        }

        private PersonAndBalance FindPersonWithBiggestLoss()
        {
            var biggestLoss = _peopleAndBalances[0].GetLoss();
            var personWithBiggestLoss = _peopleAndBalances[0];
            for (int i = 0; i < _peopleAndBalances.Length; i++)
            {
                var loss = _peopleAndBalances[i].GetLoss();
                if (biggestLoss > loss)
                {
                    biggestLoss = loss;
                    personWithBiggestLoss = _peopleAndBalances[i];
                }
            }
            return personWithBiggestLoss;
        }

        private float FindHighestBalanceEver()
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
