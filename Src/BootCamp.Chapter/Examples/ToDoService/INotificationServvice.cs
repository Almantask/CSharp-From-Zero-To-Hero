using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public interface INotificationServvice<in TRecipient>
    {
        void Notify(TRecipient recipient, string message);
    }
}
