using Inmuebles.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Inmuebles.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
 .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
//Agrego16/01
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });
// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Inmuebles.ServerAPI"));

builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
