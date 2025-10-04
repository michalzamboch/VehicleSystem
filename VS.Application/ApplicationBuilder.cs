using Microsoft.Extensions.DependencyInjection;
using VS.Application.Interfaces;
using VS.Application.Services;
using VS.Application.Workflows;

namespace VS.Application;

public static class ApplicationBuilder
{
    public static IServiceProvider CreateVehicle()
    {
        var services = new ServiceCollection();
        
        services.AddMediator();
        services.AddSingleton<IEngineService, EngineService>();
        services.AddSingleton<StartVehicleWorkflow>();
        
        return services.BuildServiceProvider();
    }
}