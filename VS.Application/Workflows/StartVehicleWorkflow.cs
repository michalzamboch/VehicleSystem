using Mediator;
using VS.Application.Messages;

namespace VS.Application.Workflows;

public sealed class StartVehicleWorkflow : IAsyncWorkflow
{
    private readonly IMediator _mediator;
    
    public StartVehicleWorkflow(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task Run()
    {
        await _mediator.Publish(new StartEngineMessage());
    }
}
