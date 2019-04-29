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
            List<LogEntry> matches = FindEntries(string.Join(" ", _parameters.GetRange(1, _parameters.Count-1).ToArray()));
            return new ExpressionResult();
        }
    }
}
