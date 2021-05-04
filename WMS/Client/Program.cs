using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WMS.Client.DataLayer;

namespace WMS.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<MenuService>();
            builder.Services.AddSingleton<CalenderService>();
            builder.Services.AddSingleton<UpperMenuService>();
            builder.Services.AddSingleton<InnerTaskService>();
            builder.Services.AddSingleton<TabheadrightService>();
            builder.Services.AddSingleton<TabRightTimeService>();
            builder.Services.AddSingleton<TaskdatatableService>();
            await builder.Build().RunAsync();
        }
    }
}
