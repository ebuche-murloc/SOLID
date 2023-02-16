namespace SOLID.OCP.Specifications;

public class SizeSpecification : Specification<Product>
{
    private Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public override bool IsSatisfied(Product item)
    {
        return item.Size == _size;
    }
}