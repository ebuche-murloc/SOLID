namespace SingleResponsibility;

class Program
{
    public static void Main(string[] args)
    {

    }
}

//Just journal
class Journal
{
    private readonly List<string> entries = new List<string>();
    
    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    public void RemoveEntry(int index)
    {
        if (index >= 0 && entries.Count < index)
            entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }
}