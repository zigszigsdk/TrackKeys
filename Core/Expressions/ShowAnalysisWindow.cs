using System.Collections.Generic;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public class ShowAnalysisWindowExpression : Expression
    {
        public ShowAnalysisWindowExpression(List<string> parameters, JsonFile<Log> log) : base(parameters, log, "show") { }

        public override ExpressionResult Executes()
        {
            return new ExpressionResult();
        }
    }
}
