namespace VS.Domain;

public sealed class Engine
{
    public bool IsRunning { get; private set; }

    public bool Start()
    {
        IsRunning = true;
        return true;
    }

    public bool Stop()
    {
        IsRunning = false;
        return true;
    }
}