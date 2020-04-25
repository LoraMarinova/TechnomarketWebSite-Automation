using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.ForgottenPasswordPage
{
    public class ForgottenPasswordPage : BasePage<ForgottenPasswordPageElememntMap, ForgottenPasswordPageValidator>
    {
        private const string LoginPageUrl = "https://www.technomarket.bg/(and:passwordRestore)";
        public ForgottenPasswordPage() 
            : base(LoginPageUrl)
        {
        }

        public void NavigateToForgottenPasswordPage()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
            Driver.BrowserWait.Until(driver1 => (js).ExecuteScript("return document.readyState").Equals("complete"));
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-password-restore//h2")));            
        }
    }
}
