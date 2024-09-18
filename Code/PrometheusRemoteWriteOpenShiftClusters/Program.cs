using Prometheus;
using System.Threading.Tasks;

namespace Prometheus {


class Program
{
    static async Task Main(string[] args)
    {
        // // Create a counter metric
        // var counter = Metrics.CreateCounter("example_counter", "Counts things");

        // // Simulate data being pushed
        // for (int i = 0; i < 10; i++)
        // {
        //     counter.Inc();
        //     await Task.Delay(1000); // Push every second
        // }

        // // Expose metrics on a port for scraping
        // // var server = new MetricServer(hostname: "localhost", port: 9091);
        // // server.Start();

        // await Task.Delay(-1); // Keep the server running
    }
} 
}