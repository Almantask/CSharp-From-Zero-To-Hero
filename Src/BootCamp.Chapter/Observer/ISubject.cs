namespace BootCamp.Chapter.Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Deattach(IObserver observer);
        void Notify();
    }
}