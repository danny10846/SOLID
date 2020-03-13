using System;

namespace DependencyInversion.Utilities {
    public class Logger : ILogger {
        public void Log(string message) {
            Console.WriteLine($"Logging {message}");
        }
    }
}