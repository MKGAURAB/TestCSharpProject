
public interface IProductRepository<T> where T : class
{
    public IEnumerable<T> GetAll();
}