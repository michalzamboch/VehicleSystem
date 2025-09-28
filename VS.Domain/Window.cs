namespace VS.Domain;

public sealed class Window
{
    public double Rolled { get; private set; }

    public void Open()
    {
        Rolled = 1.0;
    }

    public void Close()
    {
        Rolled = 0.0;
    }
}