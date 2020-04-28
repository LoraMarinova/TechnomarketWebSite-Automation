using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
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
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser)
            .ExecuteScript("return document.readyState").Equals("complete"));
        }


        public void Logout()
        {            
            Click(this.Map.ExitButton);
            Driver.BrowserWait.Until(ExpectedConditions.InvisibilityOfElementLocated
                (By.XPath("//tm-profile//span[text()[contains(.,'Изход')]]")));            
        }

        public void ClickOnChangePasswordButton()
        {
            Click(this.Map.ChangePasswordButton);
        }

        public void TypeInCurrentPasswordInputFields(string text)
        {
            Type(Map.CurrentPasswordButton, text);
        }
        public void TypeInNewPasswordInputFields(string text)
        {
            Type(Map.NewPasswordButton, text);
        }

        public void TypeInConfirmNewPasswordInputFields(string text)
        {
            Type(Map.ConfirmNewPasswordButton, text);
        }

        public void ClickOnSaveNewPassword()
        {
            Click(Map.SaveNewPasswordButton);
            Thread.Sleep(3000);

        }

    }
}
