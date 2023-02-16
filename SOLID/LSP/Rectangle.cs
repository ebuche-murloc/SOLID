namespace SOLID.LSP;

public class Rectangle
{
    public virtual int Height { get; set; }
    public virtual int Width { get; set; }

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