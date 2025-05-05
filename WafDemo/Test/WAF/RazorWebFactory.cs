using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Test.Services;

namespace BlazorWebApp.Tests.WAF;

public class RazorWebFactory : WebApplicationFactory<RazorWeb.Program>
{
    //private IHost? _realHost;

    //protected override IHost CreateHost(IHostBuilder builder)
    //{
    //    var originalHost = builder.Build();

    //    builder.ConfigureWebHost(whb => whb.UseKestrel());
    //    var realHost = builder.Build();
    //    realHost.Start();

    //    _realHost = realHost;
    //    var addresses = realHost.Services.GetRequiredService<IServer>().Features.Get<IServerAddressesFeature>();
    //    var realServerAddress = addresses!.Addresses.Last();

    //    ClientOptions.BaseAddress = new Uri(realServerAddress);

    //    originalHost.Start();
    //    return originalHost;
    //}

    //protected override void Dispose(bool disposing)
    //{
    //    if (disposing)
    //    {
    //        _realHost?.Dispose();
    //    }

    //    base.Dispose(disposing);
    //}

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(svc =>
        {
            svc.AddTransient<IDataService, TestDataService>();
        });
    }
}