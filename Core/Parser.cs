using System.Collections.Generic;
using System.Linq;

using Core.Expressions;

namespace Core
{
    public class Parser
    {
        private Converters _converters = new Converters();

        public List<Expression> Parse(string input) => Expressionify(Tokenize(input));

        private List<Expression> Expressionify(List<List<string>> commands) =>
            commands
                .Select(command =>
                    _converters
                        .Get(command[0])
                        (command.GetRange(1, command.Count-1)))
                .ToList();

        //turns "a b;c;;;d   ef  g ;" into [["a","b"],["c"],["d", "ef","g"]]
        private List<List<string>> Tokenize(string commands) =>
            commands.Split(';')
                .Select(command => 
                    command.Split(' ')
                        .Where((word) => word != "")
                        .ToList())
                .Where(words =>
                    words.Count != 0)
                        .ToList();
    }
}
