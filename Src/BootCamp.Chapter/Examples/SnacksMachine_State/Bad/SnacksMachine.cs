using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Examples.SnacksMachine_State.Bad
{
    public class SnacksMachine
    {
        private int? _selection;
        private decimal _currentPay;
        private Dictionary<int, int> _snacks = new Dictionary<int, int>();
        private Dictionary<int, Snack> _snackLookup;
        private bool _isOn = true;

        public Snack Eject()
        {
            if (_selection.HasValue)
            {
                var snack = _snackLookup[_selection.Value];
                if (_currentPay >= snack.Price)
                {
                    _snacks[_selection.Value]--;
                    return snack;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void Select()
        {
            if (_isOn && _snacks.Any())
            {

            }
        }
    }
}
