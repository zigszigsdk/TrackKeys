using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Logs
{
    public class LogEntry
    {
        public static LogEntry Merge(List<LogEntry> entries)
        {            
            LogEntry result = new LogEntry()
            {   start = null
            ,   end = null
            ,   additionalTime = entries.Select(entry =>
                {
                    if (entry.start == null)
                        return entry.additionalTime;

                    if (entry.end == null)
                        return entry.additionalTime + DateTime.Now.Subtract((DateTime)entry.start);

                    return entry.additionalTime + ((DateTime)entry.end).Subtract((DateTime)entry.start);

                }).Aggregate(TimeSpan.Zero, (a, b) => a.Add(b))

            ,   descriptions = entries.SelectMany(entry => entry.descriptions).ToList()
            ,   removed = false
            };

            entries.ForEach(entry => entry.removed = true);

            return result;
        }

        public DateTime? start;
        public DateTime? end;
        public TimeSpan additionalTime;
        public List<string> descriptions;
        public bool removed;

        public LogEntry(string description = "")
        {
            start = DateTime.Now;
            end = null;
            additionalTime = TimeSpan.Zero;
            descriptions = description == "" ? new List<string>() : new List<string>() { description };
            removed = false;

        }
    }
}
