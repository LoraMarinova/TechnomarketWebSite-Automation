using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechnomarketWebSite_Automation.Core;
using TechnomarketWebSite_Automation.Models;

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
            Driver.BrowserWait.Until(driver1 => (js).ExecuteScript("return document.readyState").Equals("complete"));
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-register/div//h2")));
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
        public void RegisterUser(User user)
        {
            Type(this.Map.EmailInputField, user.Email);
            Type(this.Map.PasswordInputField, user.Password);            
            Click(this.Map.SalutationDropDown);

            if (user.Salutation == "Господин")
            {
                Click(this.Map.SalutationMr);
            }
            else
            {
                Click(this.Map.SalutationMs);
            }
            Type(this.Map.FirstNameInputField, user.FirstName);
            Type(this.Map.LastNameInputField, user.LastName);

            Click(this.Map.BirthDateInputField);
            //Escape
            this.action.SendKeys(Keys.Escape).Perform();           

            Type(this.Map.BirthDateInputField, user.Birthdate);
            if (user.ResivePromotionInfo == true)
            {
                SelectCheckBox(this.Map.ResivePromotionInfoCheckBox);
            }
            else
            {
                ClearCheckBox(this.Map.ResivePromotionInfoCheckBox);
            }
            if (user.AgreeToProcessPersonalData == true)
            {
                SelectCheckBox(this.Map.AgreeToProcessPersonalDataCheckBox);
            }
            else
            {
                ClearCheckBox(this.Map.AgreeToProcessPersonalDataCheckBox);
            }
            if (user.AcceptTerms == true)
            {
                SelectCheckBox(this.Map.AcceptTermsCheckBox);
            }
            else
            {
                ClearCheckBox(this.Map.AcceptTermsCheckBox);
            }
            Click(this.Map.RegistrationButton);          

            Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tm-profile-header-widget")));
        }


    }
}
