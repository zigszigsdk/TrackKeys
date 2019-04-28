using System;
using System.Collections.Generic;
using System.Linq;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class StartNewEntryExpression : Expression
    {
        public StartNewEntryExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "new") { }

        public override ExpressionResult Executes()
        {
            _log.value.entries.Last().end = DateTime.Now;
            _log.value.entries.Add(new LogEntry(string.Join(" ", _parameters.ToArray())));
            _log.Save();
            return new ExpressionResult();
        }
    }
}
