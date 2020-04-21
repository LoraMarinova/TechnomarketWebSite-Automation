using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.MainPage
{
    public class MainPage : BasePage<MainPageElementMap, MainPageValidator>
    {
        private const string MainPageUrl = "https://www.technomarket.bg/";

        public MainPage() 
            : base(MainPageUrl)
        {
        }       

        public void GoToLoginPage()
        {
            this.Map.LoginButton.Click();
        }
    }
}
