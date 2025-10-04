using VS.Domain;

namespace VS.Application.Interfaces;

public interface IEngineService
{
    IReadOnlyList<Engine> Engines { get; }

    void Start();
}