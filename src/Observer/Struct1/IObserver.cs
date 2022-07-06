namespace Observer.Struct1
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}