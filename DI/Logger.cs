using System;

namespace DI {
    internal class Logger : ILogger {
        public void Log(string message) {
            Console.WriteLine($"Write to Console: {message}");
        }
    }
}