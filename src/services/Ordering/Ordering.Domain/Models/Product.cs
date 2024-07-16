namespace Ordering.Domain.Models
{
    public class Product : Entity<ProductId>
    {
        public string name { get; private set; } = default!;
        public decimal Price { get; private set; } = default!;
    }
}
