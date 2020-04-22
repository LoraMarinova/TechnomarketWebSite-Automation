using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.RegistrationPage
{
    public class RegistrationPage : BasePage<RegistrationPageElementMap, RegistrationPageValidator>
    {
        private const string RegistrationPageUrl = "https://www.technomarket.bg/(and:register)";
        public RegistrationPage() 
            : base(RegistrationPageUrl)
        {
        }

        public void NavigateToRegistrationPage()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser).ExecuteScript("return document.readyState").Equals("complete"));
        }

        private void ClickLoginButton()
        {
            this.Map.LoginButton.Click();
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
