
internal class WakeUpState : IVendingMachineState
{
    public void HandleState(VendingMachine ctx)
    {
        Console.WriteLine("Hello! I am VendingMachine. Please Choose an product!");
        ctx.SetState(new WaitingState());
    }
}