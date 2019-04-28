namespace Core
{
    public interface ICommand
    {
        CommandResult Execute();
    }
    
    public struct CommandResult
    {
        public CommandResultStatusCode statusCode;
        public string message;
    }

    public enum CommandResultStatusCode { Ok, Error }
}
