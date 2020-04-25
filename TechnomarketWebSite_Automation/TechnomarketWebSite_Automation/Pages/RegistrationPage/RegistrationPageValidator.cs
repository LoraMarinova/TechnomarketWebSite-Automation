using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.RegistrationPage
{
   public class RegistrationPageValidator : BasePageValidator<RegistrationPageElementMap>
    {

        public void VerifyRegistrationPopUpIsDisplayed()
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-register/div//h2")));
            Assert.True(Map.RegistrationPopUp.Displayed);
        }

        public void VerifyRegistrationPopUpHeader()
        {
            Assert.True(Map.RegistrationPopUpHeader.Displayed);
            Assert.AreEqual("Регистрация в сайта на Техномаркет", Map.RegistrationPopUpHeader.Text);
        }

    }
}
