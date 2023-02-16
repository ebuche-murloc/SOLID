namespace SOLID.OCP;

public class ProductFilter
{
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        return products.Where(x => x.Color == color);
    }

    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        return products.Where(x => x.Size == size);
    }
    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        return products.Where(x => x.Size == size && x.Color == color);
    }
}