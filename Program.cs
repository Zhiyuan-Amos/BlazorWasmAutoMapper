using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasmAutoMapper
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            TimeStateContainer.Start();

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services
                .AddAutoMapper(typeof(DummyProfile));

            await builder.Build().RunAsync();
        }
    }
}
