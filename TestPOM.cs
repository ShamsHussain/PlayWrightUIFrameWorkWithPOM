using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayWrightUIE2E.Pages;
using Microsoft.Playwright;
using System.Threading.Channels;

namespace PlayWrightUIE2E
{

    public class TestPOM : BaseTest
    {
        [SetUp]
        public void TestPOMSetup()
        {
            Console.WriteLine("child class setup");
        }
        [Test(Description ="Verify user login")]
        public async Task LoginTest()
        {
           // var browser = await BrowserType.LaunchAsync(new BrowserTypeLaunchOptions { Channel = "msedge"});
            var page = new LoginPage(await browserInstance.NewPageAsync());
            await page.NavigatetoTarget();
            await page.ClickOnLogin();
            await page.UserCredentialsSubmit("Ztestuser","Test@123");
            await browserInstance.CloseAsync();
      
        }



    }
}
