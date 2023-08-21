
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightUIE2E
{
    public class NetworkTestClass:PageTest
    {
        [Test]
        public async Task NetworkRequestTest()
        {
            //shows https request and response
            var page = await Browser.NewPageAsync();
            page.Request += (_, request) => Console.WriteLine(">> " + request.Method + " " + request.Url);
            page.Response += (_, response) => Console.WriteLine("<< " + response.Status + " " + response.Url);
            await page.GotoAsync("https://www.google.com");
        }

        [Test]
        public async Task NetworkResponseAssertion()
        {
            //wait for response
            var page = await Browser.NewPageAsync();
            await page.GotoAsync("https://WWW.google.com");
            var waitResponse= page.WaitForResponseAsync(urlOrPredicate:"https://WWW.google.com");
            var getResponse = waitResponse.Id;
            Console.WriteLine(getResponse);
        }
    }
}
