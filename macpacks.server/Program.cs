using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MacPacks.App.View;

namespace macpacks.server
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<DashboardView>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.TryAddDashboardViewServices
            (
                new DashboardViewConfigBuilder()
                .WithIsServer(false)
                .WithIsPreRendering(false)
                .WithResponsive(true)
                .Build()
            );

            await builder.Build().RunAsync();
        }
    }
}