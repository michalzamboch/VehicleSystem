using Mediator;
using Microsoft.Extensions.DependencyInjection;

namespace VS.Application.Test;

[TestFixture]
public sealed class StartVehicleWorkflowTest
{
    private IServiceProvider _serviceProvider;
    private IMediator _mediator;

    [SetUp]
    public void SetUp()
    {
        _serviceProvider = ApplicationBuilder.CreateVehicle();
        _mediator = _serviceProvider.GetRequiredService<IMediator>();
    }

    [TearDown]
    public void TearDown()
    {
        ((IDisposable)_serviceProvider).Dispose();
    }
    
    [Test]
    public async Task StartTest()
    {
        //_mediator.Send()
    }
}