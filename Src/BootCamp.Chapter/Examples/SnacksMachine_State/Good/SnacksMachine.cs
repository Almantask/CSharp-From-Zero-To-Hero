using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter.Examples.SnacksMachine_State.Good
{
    public class SnacksMachine
    {
        private ISnacksMachineState _state;

        public SnacksMachine()
        {
            _state = new ReadyMachine();
        }

        public Snack Eject()
        {
            var snack = _state.Eject();
            _state = new ReadyMachine();

            return snack;
        }

        public void Select(int id)
        {
            _state.Select(id);
            _state = new SelectionMade();
        }

        public void Pay(int quarters)
        {
            _state.Pay(quarters);
            _state = new MoneyPaid();
        }
    }
}
