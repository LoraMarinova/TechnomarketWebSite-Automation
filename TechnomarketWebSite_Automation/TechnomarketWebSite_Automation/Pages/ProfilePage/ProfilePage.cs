﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.ProfilePage
{
    public class ProfilePage : BasePage <ProfilePageElementMap, ProfilePageValidator>
    {
        private const string ProfilePageUrl = "https://www.technomarket.bg/profile";
        public ProfilePage() 
            : base(ProfilePageUrl)
        {
        }

        public void NavigateToProfilePage()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser).ExecuteScript("return document.readyState").Equals("complete"));
        }


        public void Logout()
        {
            NavigateToProfilePage();
            Click(this.Map.ExitButton);
        }

    }
}
