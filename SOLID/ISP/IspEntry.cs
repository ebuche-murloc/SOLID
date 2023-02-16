namespace SOLID.ISP;

public class Document
{
}

public interface IMachine
{
    void Print(Document d);
    void Fax(Document d);
    void Scan(Document d);
}

// ok if you need a multifunction machine, but IMachine better be composed of existing interfaces
public class MultiFunctionPrinter : IMachine
{
    public void Print(Document d)
    {
        //
    }

    public void Fax(Document d)
    {
        //
    }

    public void Scan(Document d)
    {
        //
    }
}

public class OldFashionedPrinter : IMachine
{
    public void Print(Document d)
    {
        // yep
    }

    public void Fax(Document d)
    {
        throw new System.NotImplementedException();
    }

    //thats pizdaboliya so its wrong
    [Obsolete("Not supported", true)]
    public void Scan(Document d)
    {
        throw new System.NotImplementedException();
    }
}

public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}

public class Printer : IPrinter
{
    public void Print(Document d)
    {

    }
}

public class Photocopier : IPrinter, IScanner
{
    public void Print(Document d)
    {
        throw new System.NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new System.NotImplementedException();
    }
}

public interface IMultiFunctionDevice : IPrinter, IScanner //
{

}

//using of decorator template, reusing some existing printer and scanner
public class MultiFunctionMachine : IMultiFunctionDevice
{
    // compose this out of several modules
    private IPrinter printer;
    private IScanner scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
        this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
    }

    public void Print(Document d)
    {
        printer.Print(d);
    }

    public void Scan(Document d)
    {
        scanner.Scan(d);
    }
}
