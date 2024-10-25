using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Google.Api;
using Blazored.LocalStorage;

namespace WIL_SPCS
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddBlazoredLocalStorage();

            await builder.Build().RunAsync();
        }
    }
}
