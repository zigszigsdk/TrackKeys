using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Core.Logs
{
    public class Log
    {
        public DateTime start;
        public List<LogEntry> entries;

        public Log(DateTime start = default(DateTime), List<LogEntry> entries = default(List<LogEntry>))
        {
            this.start = start == default(DateTime)
                ? DateTime.Now
                : start;

            this.entries = entries == default(List<LogEntry>)
                ? new List<LogEntry>() { new LogEntry() }
                : entries;
        }

        public List<LogEntry> Search(Regex regex) =>
            entries.FindAll(entry =>
                entry.descriptions.FindIndex(description =>
                    regex.IsMatch(description)) != -1);        
    }
}
