// Program.cs (ExpertFinder.Client)
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Root components - make sure you have <div id="app"></div> in wwwroot/index.html
builder.RootComponents.Add<ExpertFinder.Client.App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Read ApiBaseUrl from wwwroot/appsettings.json (if present)
var configuredApiBase = builder.Configuration["ApiBaseUrl"];

// Fallback default if not configured (change the port to your API's port if different)
var defaultApiBase = "https://learningplatformbackend-giah.onrender.com/";

// Choose the final base and ensure it ends with a slash
var apiBase = string.IsNullOrWhiteSpace(configuredApiBase) ? defaultApiBase : configuredApiBase;
if (!apiBase.EndsWith("/")) apiBase += "/";

// Log which base address is being used (appears in browser console)
Console.WriteLine($"[ExpertFinder.Client] Using API base: {apiBase}");

// Register HttpClient with the chosen base address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBase) });

// Build and run
await builder.Build().RunAsync();
