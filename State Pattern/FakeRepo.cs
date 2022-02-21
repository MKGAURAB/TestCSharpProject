public class FakeRepo : IProductRepository<Product>
{
    public IEnumerable<Product> GetAll()
    {
        return new List<Product>();
    }
}