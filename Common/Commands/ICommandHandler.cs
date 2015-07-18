namespace NorthwindStore.Common.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        CommandResult Handle(TCommand command);
    }

    public class CommandResult
    {

    }
}