# KitCli Example: Moving Between Commands

This example shows a KitCli command handing off to another with `ByMovingToCommand<T>`, ten times in a row. One user command triggers eleven command handlers in total, with no further input in between.

## How to Run

Run `/chain`:
```bash
/chain
Link 1 of 10: moving to the next command.
Link 2 of 10: moving to the next command.
Link 3 of 10: moving to the next command.
Link 4 of 10: moving to the next command.
Link 5 of 10: moving to the next command.
Link 6 of 10: moving to the next command.
Link 7 of 10: moving to the next command.
Link 8 of 10: moving to the next command.
Link 9 of 10: moving to the next command.
Link 10 of 10: moving to the next command.
All ten links ran. The chain is done.

```

One blank line prints after the whole chain, the same as any other command — not once per link. Until [#290](https://github.com/KitCli/KitCli/issues/290) (fixed in KitCli 3.1.2), `.ByMovingToCommand<T>()` printed an extra one after every link.

Each line comes from a different command's handler. `ChainCliCommandHandler` names the type of the next command and calls `.ByMovingToCommand<T>()`; that command's own handler does the same, nine more times, until the last one ends the chain with `.ByFinallySaying(...)` instead. See `ChainCliCommand.cs` for all eleven, in order.
