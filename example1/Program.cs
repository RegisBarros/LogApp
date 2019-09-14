using System;
using Serilog;

namespace LogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            log.Information("Hello, Serilo!");

            Log.Logger = log;

            MyMethod();
        }

        static void MyMethod()
        {
            Log.Information("The global logger has been configured");
        }
    }
}
