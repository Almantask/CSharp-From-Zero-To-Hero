using System.Collections.Generic;

namespace BootCamp.Chapter.Observer
{
    public interface ITile : ISubject
    {
        bool IsColored { get; }
        void Toggle();
    }

    public class Tile : ITile
    {
        public bool IsColored { private set; get; }
        private readonly IList<IObserver> _observers;

        public Tile(bool isColored)
        {
            IsColored = isColored;
            _observers = new List<IObserver>();
        }

        public void Toggle()
        {
            IsColored = !IsColored;
            Notify();
        }

        public void Attach(IObserver observer) =>
            _observers.Add(observer);

        public void Deattach(IObserver observer) =>
            _observers.Remove(observer);

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
