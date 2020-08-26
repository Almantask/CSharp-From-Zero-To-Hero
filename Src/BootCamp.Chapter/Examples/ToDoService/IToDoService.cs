using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public interface IToDoService
    {
        void Save(ToDo todo);
        void Delete(long id);
        ToDo Get(long id);
    }

    public class ToDoService : IToDoService
    {
        private readonly ILogger _logger;
        private readonly INotificationServvice<string> _notificationServvice;
        private readonly ITodoRepository _repository;
        private readonly ITelemetryTracker _telemetryTracker;

        public ToDoService(ILogger logger, INotificationServvice<string> notificationServvice, ITodoRepository repository, ITelemetryTracker telemetryTracker)
        {
            _logger = logger;
            _notificationServvice = notificationServvice;
            _repository = repository;
            _telemetryTracker = telemetryTracker;
        }

        public void Save(ToDo todo) =>
            ActService(
                $"Saving Todo with id= " + todo.Id,
                () => _repository.Save(todo));

        public void Delete(long id) =>
            ActService(
                $"Deleting Todo with id= " + id,
                () => _repository.Delete(id));

        public ToDo Get(long id) =>
            ActService(
                "Getting todo id =" + id,
                () => _repository.Get(id));

        public IEnumerable<ToDo> Get() =>
            ActService(
                "Getting all todos",
                () => _repository.Get());

        private void ActService(string message, Action action)
        {
            _telemetryTracker.Start(message);
            _logger.Info(message);
            action();
            _telemetryTracker.Stop();
        }

        private TResult ActService<TResult>(string message, Func<TResult> func)
        {
            _telemetryTracker.Start(message);
            _logger.Info(message);
            var result = func();
            _telemetryTracker.Stop();

            return result;
        }
    }
}
