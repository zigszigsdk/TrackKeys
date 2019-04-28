using System.Collections.Generic;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class GroupEntriesExpression : Expression
    {
        public GroupEntriesExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "group") { }

        public override ExpressionResult Executes()
        {
            return new ExpressionResult();
        }
    }
}
