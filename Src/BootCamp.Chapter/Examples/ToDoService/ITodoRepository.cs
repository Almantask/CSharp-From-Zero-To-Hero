using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public interface ITodoRepository
    {
        void Save(ToDo todo);
        void Delete(long id);
        ToDo Get(long id);
        IEnumerable<ToDo> Get();
    }
}
