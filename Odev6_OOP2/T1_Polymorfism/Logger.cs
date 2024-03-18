using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Polymorfism
{

    public abstract class BaseLogger
    {
        public abstract void Log(string logMessage);
    }

    public class TextFileLogger : BaseLogger
    {
        public string FileName { get; set; } = "default-log";

        public override void Log(string logMessage)
        {
            Console.WriteLine($"{DateTime.Now} - {logMessage}");
        }
    }

    public class ControlLogger : BaseLogger
    {
        public required object control { get; set; }
        public override void Log(string logMessage)
        {
            Console.WriteLine($"'{DateTime.Now} - {logMessage}' log sent to control.");
        }
    }
}
