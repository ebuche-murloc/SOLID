namespace SOLID.OCP;

public class ProductFilter
{
    //that doesn't scale well and breaks OC principle because if we need new filter method - we need to change existing and that could change behavior of that class 
    // (not in that case where we just add methods, but could theoretically)
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