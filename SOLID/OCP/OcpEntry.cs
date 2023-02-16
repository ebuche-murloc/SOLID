using System.Threading.Channels;
using SOLID.OCP.Filter;
using SOLID.OCP.Specifications;

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

        Console.WriteLine("Green products (old): ");
        foreach (var product in pf.FilterByColor(products, Color.Green))
        {
            Console.WriteLine($"{product.Name} is Green");
        }

        Console.WriteLine();

        var bf = new BetterFilter();
        Console.WriteLine("Large products:");
        var largeSpec = new SizeSpecification(Size.Large);
        foreach (var product in bf.Filter(products, largeSpec))
        {
            Console.WriteLine($"{product.Name} is Large");
        }

        Console.WriteLine();

        var largeBlueSpec = largeSpec & new ColorSpecification(Color.Blue);
        Console.WriteLine("Large Blue items:");
        foreach (var product in bf.Filter(products, largeBlueSpec))
        {
            Console.WriteLine($"{product.Name} is large and blue");
        }
    }
}