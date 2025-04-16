using Microsoft.Playwright.Xunit;

namespace Test;

public class PrivacyPageTests : PageTest
{
    [Fact]
    public async Task Page_LoadsSuccessfully()
    {
        using var waf = new RazorAppFactory();

        // 
        // _ = waf.CreateClient();

        waf.UseKestrel();
        waf.StartServer();
        var privacyPagePath = waf.ClientOptions.BaseAddress.ToString() + "Privacy";
        var response = await Page.GotoAsync(privacyPagePath);
        var content = await response!.TextAsync();

        await Expect(Page).ToHaveTitleAsync("Privacy Policy - RazorWeb");
        Assert.Contains(String.Join(',', TestDataService.TestData), content);
    }
}
