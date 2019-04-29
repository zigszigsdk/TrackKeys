using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Files;

using Core.Logs;

namespace Core.Expressions
{
    public enum ResultCode { OK, SyntaxError, ExecutionError }
    public struct ExpressionResult
    {
        public ResultCode statusCode;
        public string description;
        public Exception exception;

        public ExpressionResult(ResultCode statusCode = ResultCode.OK, string description = "", Exception exception = null)
        {
            this.statusCode = statusCode;
            this.description = description;
            this.exception = exception;
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

        protected List<LogEntry> FindEntries(string regexString)
        {
            Regex regex;

            try
            {
                regex = new Regex(regexString);
            }
            catch (Exception e)
            {
                return new List<LogEntry>();
            }

            return _log.value.Search(regex);
        }

        protected ExpressionResult RegexModification(string regex, Action<LogEntry> action)
        {
            FindEntries(regex).ForEach(action);
            return new ExpressionResult();
        }
    }
}
