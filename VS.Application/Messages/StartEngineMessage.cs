using Mediator;
using VS.Application.Interfaces;

namespace VS.Application.Messages;

public sealed class StartEngineMessage : INotification;

public sealed class StartEngineHandler : INotificationHandler<StartEngineMessage>
{
    private readonly IEngineService _engineService;

    public StartEngineHandler(IEngineService engineService)
    {
        _engineService = engineService;
    }
    
    public ValueTask Handle(StartEngineMessage notification, CancellationToken cancellationToken)
    {
        _engineService.Start();
        return default;
    }
}
