using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ScopeTransientSingletonWASM;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<TransientTest>();
builder.Services.AddScoped<ScopedTest>();
builder.Services.AddSingleton<SingletonTest>();

await builder.Build().RunAsync();
