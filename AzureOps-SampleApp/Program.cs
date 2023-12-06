using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AzureOps_SampleApp.Data;
using AzureOps_SampleApp;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AzureOps_SampleAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureOps_SampleAppContext") ?? throw new InvalidOperationException("Connection string 'AzureOps_SampleAppContext' not found.")));
builder.Services.AddHealthChecks().AddCheck<SampleHealthCheck>("Sample");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapHealthChecks("/healthz");

app.Run();
