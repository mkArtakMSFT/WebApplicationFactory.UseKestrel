using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

public class RazorAppFactory : WebApplicationFactory<Program>{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(svc =>
        {
            var dataServiceDescriptor = svc.SingleOrDefault(d=>d.ServiceType == typeof(IDataService));
            svc.Remove(dataServiceDescriptor);

            svc.AddTransient<IDataService, TestDataService>();
        });
    }
}