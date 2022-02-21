internal class WaitingState : IVendingMachineState
{
    public void HandleState(VendingMachine ctx)
    {
        Console.WriteLine("Waiting for customer to give product number and coins!");
    }
}