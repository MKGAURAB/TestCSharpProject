internal class DeliveryState : IVendingMachineState
{
    public void HandleState(VendingMachine ctx)
    {
        Console.WriteLine("Product has been vended and item has been delivered.");
        ctx.SetState(new WaitingState());
    }
}