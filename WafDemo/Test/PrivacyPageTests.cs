using BlazorWebApp.Tests.WAF;
using Microsoft.Playwright.Xunit;
using Test.Services;

namespace Test;

public class PrivacyPageTests : PageTest
{
    [Fact]
    public async Task Page_LoadsSuccessfully()
    {
        using var waf = new RazorWebFactory();

        // 
        // _ = waf.CreateClient();

        waf.UseKestrel(5002);
        waf.StartServer();

        await Task.Delay(30000);
        var privacyPagePath = waf.ClientOptions.BaseAddress.ToString() + "Privacy";

        var response = await Page.GotoAsync(privacyPagePath);
        var content = await response!.TextAsync();

        await Expect(Page).ToHaveTitleAsync("Privacy Policy - RazorWeb");
        Assert.Contains(String.Join(',', TestDataService.TestData), content);
    }
}