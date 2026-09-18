using KitCli;
using KitCli.Example.MovingBetweenCommands;

var app = new CliAppBuilder()
    .WithApp<MovingBetweenCommandsCliApp>()
    .WithRegistry<MovingBetweenCommandsRegistry>();

await app.Run();
