using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightUIE2E
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            //Playwright 
            using var playwright = await Playwright.CreateAsync();
            // Browser 
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });
            //page 
            var page = await browser.NewPageAsync();
            await page.GotoAsync("http://www.eaapp.somee.com/");
            await page.GetByText("Login").ClickAsync();
            //await page.ScreenshotAsync();
            //await page.ClickAsync(selector:"text=login");
            await page.GetByText("UserName").FillAsync("Ztestuser");
            await page.GetByText("Password").FillAsync("Test@123");
            await page.GetByText("Log in").ClickAsync();
            
        }
    }
}