class Player : ISubscriber, IPublisher
{
    private string _name;
    private int _position;

    private ISubscriber? _game;
    public Player(int Id)
    {
        _name = "Player " + Id;
        _position = 0;
    }

    public string Name => _name;
    public int Position => _position;

    public void Attach(ISubscriber subscriber)
    {
        if (subscriber is Game game)
        {
            Console.WriteLine("Attaching subscriber: " + game + " to Player " + this.Name);
            _game = game;
        }
    }

    public void Dettach(ISubscriber subscriber)
    {
        throw new NotImplementedException();
    }

    public void Notify()
    {
        _game?.Update(this);
    }

    public void Update(IPublisher publisher)
    {
        if (publisher is Dice dice)
        {
            _position = dice.GetRollCount;
            Console.WriteLine($"{_name}'s poisiton changed to {_position}. Notifying state change to Game.");
            this.Notify();
        }
    }
}