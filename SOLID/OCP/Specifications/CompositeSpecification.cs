namespace SOLID.OCP.Specifications;

public abstract class CompositeSpecification<T> : Specification<T>
{
    protected readonly Specification<T>[] _items;

    protected CompositeSpecification(params Specification<T>[] items)
    {
        _items = items;
    }
}