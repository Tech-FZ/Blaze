using Microsoft.EntityFrameworkCore;
using Test_Demo1.Data;
using Test_Demo1.Components;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<BlazeDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("BlazeDbContext") 
                    ?? throw new NullReferenceException("BlazeDbContext connection string not found."))); 


builder.Services.AddQuickGridEntityFrameworkAdapter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Source - https://stackoverflow.com/a/75030125
// Posted by yetanothercoder
// Retrieved 2026-09-24, License - CC BY-SA 4.0

#pragma warning disable ASP0013 // Suggest switching from using Configure methods to WebApplicationBuilder.Configuration
builder.WebHost.ConfigureAppConfiguration((ctx, cb) =>
    {
        if (!ctx.HostingEnvironment.IsDevelopment())
        {
            StaticWebAssetsLoader.UseStaticWebAssets(
            ctx.HostingEnvironment,
            ctx.Configuration);
        }
    }
);
#pragma warning restore ASP0013 // Suggest switching from using Configure methods to WebApplicationBuilder.Configuration


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialise(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
