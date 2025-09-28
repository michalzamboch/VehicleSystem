using Microsoft.Extensions.DependencyInjection;

namespace VS.Application;

public static class ApplicationBuilder
{
    public static IServiceProvider CreateVehicle()
    {
        var services = new ServiceCollection();
        
        return services.BuildServiceProvider();
    }
}