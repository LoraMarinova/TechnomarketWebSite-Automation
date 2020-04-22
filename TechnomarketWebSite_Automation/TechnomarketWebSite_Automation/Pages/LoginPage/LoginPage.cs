using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.LoginPage
{
    public class LoginPage : BasePage<LoginPageElementMap, LoginPageValidator>
    {
        private const string LoginPageUrl = "https://www.technomarket.bg/(and:login)";
        public LoginPage() 
            : base(LoginPageUrl)
        {
        }

        public void NavigateToLoginPage()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser).ExecuteScript("return document.readyState").Equals("complete"));
        }

        private void ClickLoginButton()
        {
            this.Map.LoginButtonInLoginPopUp.Click();
        }

        private void ClickRegistrationButton()
        {
            this.Map.RegistrationButton.Click();
        }

        private void ClickForgottenPasswordButton()
        {
            this.Map.ForgottenPasswordButton.Click();
        }
    }
}
