using System;
using System.Collections.Generic;

using Files;

using Core.Expressions;
using Core.Logs;

namespace Core
{
    public delegate Expression Converter(List<string> parameters);

    class Converters
    {
        private static JsonFile<Log> _log = new JsonFile<Log>(
            new FilePath(@"C:\Users\zigs\Desktop\hi.json")
        ,   new Log()
        );
        
        public Converter Get(string key) =>
            converters.ContainsKey(key.ToLower())
                ? converters[key.ToLower()](_log)
                : (List<string> parameters) => new ErrorExpression(key, parameters, _log);

        private Dictionary<string, Func<JsonFile<Log>, Converter>> converters 
            = new Dictionary<string, Func<JsonFile<Log>, Converter>>()
        {   { "new", (log) => (List<string> parameters) => new StartNewEntryExpression(parameters, log)}
        ,   { "show", (log) => (List<string> parameters) => new ShowAnalysisWindowExpression(parameters, log)}
        ,   { "desc", (log) => (List<string> parameters) => new DescribeEntryExpression(parameters, log)}
        ,   { "group", (log) => (List<string> parameters) => new GroupEntriesExpression(parameters, log)}
        ,   { "remove", (log) => (List<string> parameters) => new RemoveEntryExpression(parameters, log)}
        };        
    }
}
