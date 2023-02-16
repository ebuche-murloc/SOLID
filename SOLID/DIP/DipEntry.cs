namespace SOLID.DIP;

public class DipEntry
{
    public static void Main(string[] args)
    {
        var parent = new Person { Name = "John" };
        var child1 = new Person { Name = "Chris" };
        var child2 = new Person { Name = "Matt" };

        // low-level module
        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);

        new Research(relationships);
    }
}

public class Research
{
    public Research(Relationships relationships)
    {
        //high - level: find all of john's children
        var relations = relationships.Relations;
        foreach (var r in relations
          .Where(x => x.Item1.Name == "John"
                      && x.Item2 == Relationship.Parent))
        {
            Console.WriteLine($"John has a child called {r.Item3.Name}");
        }
    }
}