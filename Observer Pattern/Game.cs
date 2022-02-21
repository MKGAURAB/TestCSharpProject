public sealed class Game : ISubscriber
{
    Dice OneDice = new Dice();

    Player p1 = new Player(1);
    Player p2 = new Player(2);

    private Game()
    {
        OneDice.Attach(p1);
        OneDice.Attach(p2);

        p1.Attach(this);
        p2.Attach(this);
    }

    private static readonly Lazy<Game> lazy = new Lazy<Game>(() => new Game());

    public static Game Instance
    {
        get
        {
            return lazy.Value;
        }
    }

    public void Run_Game()
    {
        for (int i = 1; i > 0 && OneDice.GetRollCount > -1; ++i)
        {
            OneDice.Roll();
        }
    }
    public void Update(IPublisher publisher)
    {
        if (publisher is Player player && player.Position >= 100)
        {
            Console.WriteLine($"{player.Name} has won! Hurray.");
            OneDice.InvalidateDice();
        }
    }
}