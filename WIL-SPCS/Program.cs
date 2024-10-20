using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Google.Api;

namespace WIL_SPCS
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            string path = @"C:\Users\User\source\repos\WIL-SPCA-app\WIL-SPCS\wilspca-firebase-adminsdk-vhocd-efcb1bb217.json"; ;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
