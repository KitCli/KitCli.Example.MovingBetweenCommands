using KitCli.Abstractions;
using KitCli.Commands.Abstractions.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace KitCli.Example.MovingBetweenCommands;

public class MovingBetweenCommandsRegistry : ICliAppRegistry
{
    public void Register(IServiceCollection services)
    {
        var programAssembly = typeof(Program).Assembly;

        services.AddCommandsFromAssembly(programAssembly);
    }
}
