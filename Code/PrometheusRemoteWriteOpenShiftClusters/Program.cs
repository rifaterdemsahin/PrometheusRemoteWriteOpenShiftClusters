using System;
using System.Threading.Tasks;
using Prometheus;

namespace PrometheusExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Set up the colors for the console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting Prometheus Example...");

            // Create a counter metric
            var counter = Metrics.CreateCounter("example_counter", "Counts things");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Counter metric created. Starting to push data...");

            // Simulate data being pushed
            for (int i = 0; i < 10; i++)
            {
                counter.Inc();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Counter incremented: {i + 1}");

                await Task.Delay(1000); // Push every second
            }

            // Expose metrics on a port for scraping
            var server = new MetricServer(hostname: "localhost", port: 9091);
            server.Start();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Metric server started at http://localhost:9091.");

            // Keep the server running indefinitely
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Server running... Press Ctrl+C to stop.");

            await Task.Delay(-1); // Keep the server running
        }
    }
}
