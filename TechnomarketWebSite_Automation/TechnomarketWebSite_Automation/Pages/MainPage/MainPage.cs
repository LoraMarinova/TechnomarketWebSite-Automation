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
        }

        public void GoToCart()
        {
            this.Map.CartButton.Click();
        }    

    }
}
