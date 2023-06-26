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

                // the previous line of code will create a string in the following format "6/26/2023 2:38:14 PM, Some kind of text, Medium"
                // please write the value of the logStr variable to a file and return true if it was written to the file successfully.
                
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
