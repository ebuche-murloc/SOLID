namespace SOLID.DIP;

public class Research
{
    //public Research(Relationships relationships)
    //{
        ////high - level: find all of john's children depends on low-level, if how relations stored changes - this code stop work and must be remade
        //var relations = relationships.Relations;
        //foreach (var r in relations
        //             .Where(x => x.Item1.Name == "John"
        //                         && x.Item2 == Relationship.Parent))
        //{
        //    Console.WriteLine($"John has a child called {r.Item3.Name}");
        //}
    //}

    public Research(IRelationshipBrowser browser)
    {
        foreach (var r in browser.FindAllChildrenOF("John"))
        {
            Console.WriteLine($"John has a child called {r.Name}");
        }
    }
}