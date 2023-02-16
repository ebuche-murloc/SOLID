namespace SOLID.LSP;

public class LspEntry
{
    public static void Main(string[] args)
    {
        var rc = new Rectangle(2, 3); // exp 30 got 30
        UseIt(rc);

        var sq = new Square(5);
        UseIt(sq); // exp 50 got 100
    }

    public static void UseIt(Rectangle r)
    {
        int width = r.Width;
        r.Height = 10;
        Console.WriteLine($"Expected area of {10 * width}, got {r.Area}");
    }
}