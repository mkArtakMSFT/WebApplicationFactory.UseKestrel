using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Playwright.Xunit;

namespace Test;

public class UnitTest1 : PageTest
{
    [Fact]
    public async Task WeatherPage_LoadsSuccessfully()
    {
        using var waf = new RazorAppFactory();
        
        // 
        // _ = waf.CreateClient();

        waf.UseKestrel();
        waf.StartServer();

        var privacyPagePath = waf.ClientOptions.BaseAddress.ToString() + "Privacy";
        var response = await Page.GotoAsync(privacyPagePath);
        await Expect(Page).ToHaveTitleAsync("Privacy Policy - RazorWeb");
    }
}
