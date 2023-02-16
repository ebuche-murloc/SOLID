namespace SOLID.DIP;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOF(string name);
}