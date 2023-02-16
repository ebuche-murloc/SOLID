using SOLID.OCP.Specifications;

namespace SOLID.OCP.Filter;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
}