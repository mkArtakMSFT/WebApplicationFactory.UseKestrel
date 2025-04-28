using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Test.Services;

namespace BlazorWebApp.Tests.WAF;

public class RazorWebFactory : WebApplicationFactory<RazorWeb.Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(svc =>
        {
            svc.AddTransient<IDataService, TestDataService>();
        });
    }
}