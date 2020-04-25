using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.ForgottenPasswordPage
{
    public class ForgottenPasswordPageValidator : BasePageValidator<ForgottenPasswordPageElememntMap>
    {
        public void VerifyForgottenPasswordPopUpIsDisplayed()
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-password-restore/div//h2")));
            Assert.True(Map.ForgottenPasswordPopup.Displayed);            
        }
        
    }
}
