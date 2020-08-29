using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.SnacksMachine_State.Good
{
    public interface ISnacksMachineState
    {
        Snack Eject();
        void Select(int id);
        void Pay(int money);
    }

    public class ReadyMachine : ISnacksMachineState
    {
        public Snack Eject()
        {
            throw new NotImplementedException();
        }

        public void Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Pay(int money)
        {
            throw new NotImplementedException();
        }
    }

    public class MoneyPaid : ISnacksMachineState
    {
        // selected id
        // decrement

        public Snack Eject()
        {
            // Pick snack to return.
            return null;
        }

        public void Select(int id)
        {
            Console.WriteLine("Not supported");
        }

        public void Pay(int money)
        {
            Console.WriteLine("Not supported");
        }
    }

    public class SelectionMade : ISnacksMachineState
    {
        public Snack Eject()
        {
            throw new NotImplementedException();
        }

        public void Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Pay(int money)
        {
            throw new NotImplementedException();
        }
    }
}
