using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightUIE2E
{
    public class BaseTest:PageTest
    {
        public IBrowser browserInstance { get; set; }

        [SetUp]
        public void setupmethod()
        {
            browserInstance = BrowserType.LaunchAsync(new BrowserTypeLaunchOptions { Channel = "msedge" }).Result;
        }
    }
}
