namespace SingleResponsibility;

class Program
{
    public static void Main(string[] args)
    {

    }
}

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

    //adding file manipulation logic and breaking SR principle
    public void Save(string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
            File.WriteAllText(filename, entries.ToString());
    }

    public void Load(string filename)
    {
        foreach (var s in File.ReadAllLines(filename))
            entries.Add(s);
    }
}