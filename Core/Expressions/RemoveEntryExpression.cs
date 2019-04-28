using System.Collections.Generic;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class RemoveEntryExpression : Expression
    {
        public RemoveEntryExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "remove") { }

        public override ExpressionResult Executes()
        {
            return new ExpressionResult();
        }
    }
}
