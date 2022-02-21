class Dice : IPublisher
{
    private List<ISubscriber> subscribers;
    private int rollCount;

    public Dice()
    {
        rollCount = 0;
        subscribers = new List<ISubscriber>();
    }

    public void Attach(ISubscriber subscriber)
    {
        if (subscriber is Player player)
        {
            Console.WriteLine("Attaching subscriber " + player.Name);
            subscribers.Add(subscriber);
        }
    }

    public void Dettach(ISubscriber subscriber)
    {
        if (subscriber is Player player)
        {
            Console.WriteLine("Dettaching subscriber " + player.Name);
            subscribers.Remove(subscriber);
        }
    }

    public void Roll()
    {
        rollCount += 1;
        this.Notify();
    }

    public int GetRollCount => this.rollCount;
    public void InvalidateDice()
    {
        rollCount = -1;
    }

    public void Notify()
    {
        int subCnt = subscribers.Count;
        Console.WriteLine("Subscriber Notifying: ....");
        subscribers[rollCount % subCnt].Update(this);
    }
}