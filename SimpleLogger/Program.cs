using System;

namespace SimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerObj = new SimpleLogger { LogFilePath = @"c:\LogfileDir\" };

            loggerObj.WriteToLog(DateTime.Now, "XXXXX", SimpleLogger.Severity.Low);
        }
    }
}
