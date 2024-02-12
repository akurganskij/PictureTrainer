using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using PictureTrainer;
using System.Diagnostics.CodeAnalysis;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()));

builder.Services.AddLocalization();

var host = builder.Build();
await host.SetDefaultCulture();
await host.RunAsync();


public partial class Program
{
    [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
    private static Type _keepDateOnly = typeof(DateOnly);
}