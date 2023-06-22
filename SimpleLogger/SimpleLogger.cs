using System;

namespace SimpleLogger
{
    public class SimpleLogger
    {
        public string LogFilePath { get; set; }

        public enum Severity
        {
            VeryLow,
            Low,
            Mid,
            High,
            ExtremyHigh
        };

        public bool WriteToLog(DateTime eventTime, string whatHappened, Severity severityLevel)
        {
            try
            {
                var logStr = $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}, {whatHappened}, {severityLevel}";
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
