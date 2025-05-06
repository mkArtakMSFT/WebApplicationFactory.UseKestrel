using BlazorWebApp.Tests.WAF;
using Microsoft.Playwright.Xunit;
using Test.Services;

namespace Test;

public class PrivacyPageTests : PageTest
{
    [Fact]
    public async Task Page_LoadsSuccessfully()
    {
        #region Not supported approach
        // 
        // _ = waf.CreateClient();
        #endregion

        using var waf = new RazorWebFactory();

        waf.UseKestrel();
        waf.StartServer();

        var privacyPagePath = waf.ClientOptions.BaseAddress.ToString() + "Privacy";

        var response = await Page.GotoAsync(privacyPagePath);
        var content = await response!.TextAsync();

        await Expect(Page).ToHaveTitleAsync("Privacy Policy - RazorWeb");
        Assert.Contains(TestDataService.TestData, content);
    }
}