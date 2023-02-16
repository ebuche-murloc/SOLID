namespace SOLID.LSP;

public class Square : Rectangle
{
    public Square()
    {
        
    }
     
    public Square(int side)
    {
        Width = Height = side;
    }

    //with "new" it calls old property when upcasted
    public new int Height
    {
        set => base.Width = base.Height = value;
    }

    public new int Width
    {
        set => base.Width = base.Height = value;
    }
}