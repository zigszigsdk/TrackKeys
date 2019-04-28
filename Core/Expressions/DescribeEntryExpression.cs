using System.Collections.Generic;
using System.Linq;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class DescribeEntryExpression : Expression
    {
        public DescribeEntryExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "desc") { }

        public override ExpressionResult Executes()
        {
            _log.value.entries.Last().descriptions.Add(string.Join(" ", _parameters.ToArray()));
            _log.Save();
            return new ExpressionResult();
        }
    }
}
