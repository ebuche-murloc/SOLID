namespace SOLID.LSP;

public class LspEntry
{
    public static void Main(string[] args)
    {
        var rc = new Rectangle(2, 3);
        UseIt(rc);

        var sq = new Square(5);
        UseIt(sq);
    }

    public static void UseIt(Rectangle r)
    {
        int width = r.Width;
        r.Height = 10;
        Console.WriteLine($"Expected area of {10 * width}, got {r.Area}");
    }
}