using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class RemoveEntryExpression : Expression
    {
        public RemoveEntryExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "remove") { }

        public override ExpressionResult Executes() =>
            RegexModification(string.Join(" ", _parameters.ToArray()), entry => entry.removed = true);
    }
}
