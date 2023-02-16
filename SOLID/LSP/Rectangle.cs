namespace SOLID.LSP;

public class Rectangle
{
    public int Height { get; set; }
    public int Width { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(int height, int width)
    {
        Height = height;
        Width = width;
    }

    public int Area => Height * Width;

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}