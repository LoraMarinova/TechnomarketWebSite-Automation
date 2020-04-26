using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;
using TechnomarketWebSite_Automation.Enums;

namespace TechnomarketWebSite_Automation.Pages.MainPage
{
    public class MainPage : BasePage<MainPageElementMap, MainPageValidator>
    {
        private const string MainPageUrl = "https://www.technomarket.bg/";

        public MainPage() 
            : base(MainPageUrl)
        {
        }  

        public void GoToLogin()
        {
            this.Map.LoginButton.Click();
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-login/div//h2")));
        }

        public void GoToCart()
        {
            this.Map.CartButton.Click();
        }  
        
        public void GoToProfile()
        {
            Click(Map.ProfileButton);
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-profile//span[text()[contains(.,'Изход')]]")));


        }

    }
}
