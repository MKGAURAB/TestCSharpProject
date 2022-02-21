public interface IPublisher
{
    public void Attach(ISubscriber subscriber);
    public void Dettach(ISubscriber subscriber);
    public void Notify();
}