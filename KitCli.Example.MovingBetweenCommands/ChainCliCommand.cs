using KitCli.Commands.Abstractions;
using KitCli.Commands.Abstractions.Handlers;
using KitCli.Commands.Abstractions.Outcomes;

namespace KitCli.Example.MovingBetweenCommands;

public record ChainCliCommand : CliCommand;

public class ChainCliCommandHandler : CliCommandHandler<ChainCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 1 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkTwoCliCommand>()
            .EndAsync();
}

public record ChainLinkTwoCliCommand : CliCommand;

public class ChainLinkTwoCliCommandHandler : CliCommandHandler<ChainLinkTwoCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkTwoCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 2 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkThreeCliCommand>()
            .EndAsync();
}

public record ChainLinkThreeCliCommand : CliCommand;

public class ChainLinkThreeCliCommandHandler : CliCommandHandler<ChainLinkThreeCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkThreeCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 3 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkFourCliCommand>()
            .EndAsync();
}

public record ChainLinkFourCliCommand : CliCommand;

public class ChainLinkFourCliCommandHandler : CliCommandHandler<ChainLinkFourCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkFourCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 4 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkFiveCliCommand>()
            .EndAsync();
}

public record ChainLinkFiveCliCommand : CliCommand;

public class ChainLinkFiveCliCommandHandler : CliCommandHandler<ChainLinkFiveCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkFiveCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 5 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkSixCliCommand>()
            .EndAsync();
}

public record ChainLinkSixCliCommand : CliCommand;

public class ChainLinkSixCliCommandHandler : CliCommandHandler<ChainLinkSixCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkSixCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 6 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkSevenCliCommand>()
            .EndAsync();
}

public record ChainLinkSevenCliCommand : CliCommand;

public class ChainLinkSevenCliCommandHandler : CliCommandHandler<ChainLinkSevenCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkSevenCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 7 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkEightCliCommand>()
            .EndAsync();
}

public record ChainLinkEightCliCommand : CliCommand;

public class ChainLinkEightCliCommandHandler : CliCommandHandler<ChainLinkEightCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkEightCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 8 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkNineCliCommand>()
            .EndAsync();
}

public record ChainLinkNineCliCommand : CliCommand;

public class ChainLinkNineCliCommandHandler : CliCommandHandler<ChainLinkNineCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkNineCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 9 of 10: moving to the next command.")
            .ByMovingToCommand<ChainLinkTenCliCommand>()
            .EndAsync();
}

public record ChainLinkTenCliCommand : CliCommand;

public class ChainLinkTenCliCommandHandler : CliCommandHandler<ChainLinkTenCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainLinkTenCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .BySaying("Link 10 of 10: moving to the next command.")
            .ByMovingToCommand<ChainCompleteCliCommand>()
            .EndAsync();
}

public record ChainCompleteCliCommand : CliCommand;

public class ChainCompleteCliCommandHandler : CliCommandHandler<ChainCompleteCliCommand>
{
    public override Task<Outcome[]> HandleCommand(ChainCompleteCliCommand command, CancellationToken cancellationToken)
        => FinishThisCommand()
            .ByFinallySaying("All ten links ran. The chain is done.")
            .EndAsync();
}
