public class VendingMachine
{
    private IVendingMachineState? _state;
    private IProductRepository<Product>? _productRepo;
    public VendingMachine(IProductRepository<Product> productRepository)
    {
        SetState(new WakeUpState());
        _productRepo = productRepository;
    }

    public List<Product> ListAllProduct()
    {
        return _productRepo?.GetAll()
            .ToList() ?? new List<Product>();
    }

    public void SetState(IVendingMachineState idleState)
    {
        _state = idleState;
        _state.HandleState(this);
    }

    public void RequestProduct(string productId, double number)
    {
        if (_state is WaitingState) SetState(new PreparingState(productId, number));
    }

    public bool IsWaitingForUser() => _state is WaitingState;
}