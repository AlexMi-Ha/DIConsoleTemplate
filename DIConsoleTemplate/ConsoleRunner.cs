
using DIConsoleTemplate.Interfaces;

namespace DIConsoleTemplate {
    internal class ConsoleRunner : IRunner {

        public ConsoleRunner() { }

        public void Run(string[] args) {
            Console.WriteLine("Hello World");
        }
    }
}
