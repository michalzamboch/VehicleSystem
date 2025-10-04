using Microsoft.Extensions.DependencyInjection;
using VS.Application;
using VS.Application.Interfaces;
using VS.Application.Workflows;

var vehicle = ApplicationBuilder.CreateVehicle();

var startVehicleWorkflow = vehicle.GetRequiredService<StartVehicleWorkflow>();
var engineService = vehicle.GetRequiredService<IEngineService>();

await startVehicleWorkflow.Run();

Console.WriteLine("Press any key to exit...");
