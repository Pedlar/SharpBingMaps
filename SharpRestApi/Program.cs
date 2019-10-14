using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace SharpRestApi {
    class Program {
        static void Main(string[] args) {
            var host = new WebHostBuilder()
                           .UseContentRoot(Directory.GetCurrentDirectory())
                           .UseStartup<Startup>()
                           .UseIISIntegration()
                           .UseKestrel()
                           .Build();
            host.Run();
        }
    }
}
