namespace SOLID.OCP;

public class OcpEntry
{
    public static void Main(string[] args)
    {
        var apple = new Product("apple", Color.Green, Size.Small);
        var tree = new Product("tree", Color.Green, Size.Large);
        var house = new Product("house", Color.Blue, Size.Large);

        Product[] products = { apple, tree, house };

        var pf = new ProductFilter();

        foreach (var product in pf.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($"{product.Name} is Green");
        }
    }
}