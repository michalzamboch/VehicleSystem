using Microsoft.Extensions.DependencyInjection;
using VS.Application.Interfaces;

namespace VS.Application;

public static class ApplicationBuilder
{
    public static IServiceProvider CreateVehicle()
    {
        var services = new ServiceCollection();
        
        services.AddMediator();
        
        return services.BuildServiceProvider();
    }
}