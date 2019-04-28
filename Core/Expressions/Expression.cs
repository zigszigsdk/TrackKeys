using System.Collections.Generic;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public enum ResultCode { OK, SyntaxError, ExecutionError }
    public struct ExpressionResult
    {
        public ResultCode statusCode;
        public string description;

        public ExpressionResult(ResultCode statusCode = ResultCode.OK, string description = "")
        {
            this.statusCode = statusCode;
            this.description = description;
        }
    }

    public abstract class Expression
    {
        protected List<string> _parameters;
        protected JsonFile<Log> _log;
        protected string _command;

        public Expression(List<string> parameters, JsonFile<Log> log, string command)
        {
            _parameters = parameters;
            _log = log;
            _command = command;
        }

        public string Stringify() => _command + " " + string.Join(" ", _parameters);

        public abstract ExpressionResult Executes();

    }
}
