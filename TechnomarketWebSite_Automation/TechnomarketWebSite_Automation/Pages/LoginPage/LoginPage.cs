using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-login/div//h2")));
        }

        public void ClickLoginButton()
        {
            this.Map.LoginButtonOnLoginPopUp.Click();
        }

        public void ClickRegistrationButton()
        {
            this.Map.RegistrationButton.Click();
        }

        public void ClickForgottenPasswordButton()
        {
            this.Map.ForgottenPasswordButton.Click();
        }

        public void TypeEmail(string email)
        {
            Type(this.Map.EmailInputField, email);
        }

        public void TypePassword(string pass)
        {
            Type(this.Map.PasswordInputField, pass);
        }
    }
}
