using SOLID.OCP.Specifications;

namespace SOLID.OCP.Filter;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> products, Specification<Product> spec)
    {
        return products.Where(p => spec.IsSatisfied(p));
    }
}