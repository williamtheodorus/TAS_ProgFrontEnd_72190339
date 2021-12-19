using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TAS_ProgFrontEnd_72190339.Services;

namespace TAS_ProgFrontEnd_72190339
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var uri = new Uri("https://akademikbackend.azurewebsites.net");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = uri });
            builder.Services.AddScoped<IStudentService,StudentService>();
            builder.Services.AddScoped<IEnrollmentService,EnrollmentService>();

            await builder.Build().RunAsync();
        }
    }
}
