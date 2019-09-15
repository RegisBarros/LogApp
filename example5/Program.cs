using System;
using System.Threading;
using Serilog;

namespace example5
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration()
                .WriteTo.Console()    
                .WriteTo.Http("http://localhost:5000")
                .CreateLogger();

            while (true)
            {
                var customer = Customer.Generate();                                
                log.Information("{@customer} registered", customer);                
                Thread.Sleep(1000);
            }
        }
    }
}
