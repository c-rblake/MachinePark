using MachinePark.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MachinePark
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddFlexGridServerSide and we are done. This a webassembly.. Flexgrid is for server side.
            //builder.Services.AddTransient(sp => new HttpClient
            //{
            //    BaseAddress = new Uri("https://localhost:44308/")
            //}
            //);
            //4:43
            builder.Services.AddHttpClient<IAuthorDataService, AuthorDataService>(client => 
            client.BaseAddress = new Uri("https://localhost:44308/"));

            await builder.Build().RunAsync();
        }
    }
}
