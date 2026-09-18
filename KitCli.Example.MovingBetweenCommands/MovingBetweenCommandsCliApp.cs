using KitCli.Abstractions.Io;
using KitCli.Workflow.Abstractions;

namespace KitCli.Example.MovingBetweenCommands;

public class MovingBetweenCommandsCliApp(ICliWorkflow workflow, ICliIo io) : CliApp(workflow, io);
