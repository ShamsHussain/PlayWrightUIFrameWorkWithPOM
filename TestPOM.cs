using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayWrightUIE2E.Pages;

namespace PlayWrightUIE2E
{
    public class TestPOM:PageTest
    {
        [Test]

        public async Task LoginTest()
        {
            var page = new LoginPage(await Browser.NewPageAsync());
            await page.NavigatetoTarget();
            await page.ClickOnLogin();
            await page.UserCredentialsSubmit("Ztestuser","Test@123");
      
        }

    }
}
