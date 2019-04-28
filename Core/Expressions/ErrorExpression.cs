using System.Collections.Generic;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class ErrorExpression : Expression
    {
        public ErrorExpression(string command, List<string> parameters, JsonFile<Log> log)
            : base(parameters, log, command) { }

        public override ExpressionResult Executes()
        {
            return new ExpressionResult(ResultCode.SyntaxError, "Invalid command: " + Stringify());
        }
    }
}
