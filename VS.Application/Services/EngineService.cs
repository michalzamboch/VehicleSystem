using System.Diagnostics;
using VS.Application.Interfaces;
using VS.Domain;

namespace VS.Application.Services;

internal sealed class EngineService : IEngineService
{
    public IReadOnlyList<Engine> Engines { get; }
    private readonly List<Engine> _engines = [];

    public EngineService()
    {
        // TODO: Engines should be added externally
        var newEngine = new Engine();
        Debug.Assert(!newEngine.IsRunning);
        
        _engines.Add(newEngine);
        Engines = _engines.AsReadOnly();
    }

    public void Start()
    {
        foreach (var engine in Engines)
        {
            engine.Start();
        }
    }
}