using Microsoft.EntityFrameworkCore;
using Test_Demo1.Data;
using Test_Demo1.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContextFactory<BlazeDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("BlazeDbContext") 
                    ?? throw new NullReferenceException("BlazeDbContext connection string not found."))); 

builder.Services.AddQuickGridEntityFrameworkAdapter();

/*
builder.Configuration.GetConnectionString("BlazeDbContext") ?? 
        throw new InvalidOperationException("Connection string for BlazeDbContext not found")*/

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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
