using Microsoft.EntityFrameworkCore;
using SelfHelpLedger.Data;
using SelfHelpLedger.Components;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-KE");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-KE");


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var connectionString = "Server=localhost;Database=SelfHelpLedger;User Id=sa;Password=Japh254!*#;TrustServerCertificate=True;";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
