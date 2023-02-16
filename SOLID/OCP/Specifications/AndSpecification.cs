namespace SOLID.OCP.Specifications;

public class AndSpecification<T> : CompositeSpecification<T>
{
    public AndSpecification(params Specification<T>[] items) : base(items)
    {
    }

    public override bool IsSatisfied(T item)
    {
        //Any - OrSpecification
        return _items.All(i => i.IsSatisfied(item));
    }
}