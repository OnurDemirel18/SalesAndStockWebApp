using System.ComponentModel;
using Blazor;
using Blazored.Toast;
using Configurations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
#region Components
builder.Services.AddRadzenComponents();
builder.Services.AddBlazoredToast();
#endregion
#region
builder.Services.AddScoped<IDomainService,DomainManager>();
#endregion
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
