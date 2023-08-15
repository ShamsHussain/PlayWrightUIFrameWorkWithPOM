using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightUIE2E
{
    public class AdvTestByInheritPageClass:PageTest
    {
        [SetUp]
        public async Task Setup()
        {
            await Page.GotoAsync("http://www.eaapp.somee.com/");
        }

        [Test]
        public async Task Test1()
        {
            //await Page.GetByText("Login").ClickAsync();
            //await Page.GetByText("UserName").FillAsync("Ztestuser");
            //await Page.GetByText("Password").FillAsync("Test@123");
            //await Page.GetByText("Log in").ClickAsync();
            //Advance Representation 
            Page.SetDefaultTimeout(10000);
            var LoginLocator = Page.GetByText("Login");
            await LoginLocator.ClickAsync();
            var UserNameLocator = Page.GetByText("UserName");
            await UserNameLocator.FillAsync("Ztestuser");
            var PasswordLocator = Page.GetByText("Password");
            await PasswordLocator.FillAsync("Test@123");
            var LoginBtnLocator = Page.GetByText("Log in");
            await LoginBtnLocator.ClickAsync();
            Expect(Page.GetByText("Home"));


        }
    }
}
