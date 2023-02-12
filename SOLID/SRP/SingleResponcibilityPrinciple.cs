using System.Diagnostics;

namespace SOLID.SRP;

class SRPEntry
{
    public static void SRPMain(string[] args)
    {
        var journal = new Journal();
        journal.AddEntry("Da eto josko bylo");
        journal.AddEntry("Slabovato pogg");
        Console.WriteLine(journal);

        //better using dependency injection mb
        var persistenceManager = new PersistenceManager();
        var filename = @"Z:\j.txt";
        persistenceManager.Save(journal, filename);

        var psi = new ProcessStartInfo();
        psi.FileName = filename;
        psi.UseShellExecute = true;
        Process.Start(psi);
    }
}

class PersistenceManager
{
    public void Save(Journal journal, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
            File.WriteAllText(filename, journal.ToString());
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