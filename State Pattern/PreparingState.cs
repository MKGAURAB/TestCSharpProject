
internal class PreparingState : IVendingMachineState
{
    public PreparingState(string productId, double number)
    {
        ProductId = productId;
        Number = number;
    }

    public string ProductId { get; }
    public double Number { get; }

    public void HandleState(VendingMachine ctx)
    {
        Console.WriteLine($"Fetching Product {ProductId}");
        ctx.SetState(new DeliveryState());
    }
}