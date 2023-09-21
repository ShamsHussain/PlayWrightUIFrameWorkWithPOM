using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightUIE2E.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly ILocator _loginLink;
        private readonly ILocator _userName;
        private readonly ILocator _password;
        private readonly ILocator _loginBtn;
        
        public LoginPage(IPage page)
        {
            _page = page;
            _loginLink = page.GetByText("Login");
            _userName = page.GetByText("UserName");
            _password = page.GetByText("Password");
            _loginBtn = page.GetByText("Log in");

        }

        public async Task NavigatetoTarget()
        {
            await _page.GotoAsync("http://www.eaapp.somee.com/");
        }

        public async Task ClickOnLogin()
        {
            /* this method perform 2 level wait through listing network
             * 1st before click action wait and check navigation
             * 2nd after click check navigation with targetted url
            */

            /*await _page.RunAndWaitForNavigationAsync(action: async () =>
            {
                await _loginLink.ClickAsync();
            }, new PageRunAndWaitForNavigationOptions
            {
                UrlString = "Login"
            });

            */
            await _loginLink.ClickAsync();
        }

        public async Task UserCredentialsSubmit(string UserName, string Passwrod)
        {
            await _userName.FillAsync(UserName);
            await _password.FillAsync(Passwrod);    
            await _loginBtn.ClickAsync();

        }

    }
}
