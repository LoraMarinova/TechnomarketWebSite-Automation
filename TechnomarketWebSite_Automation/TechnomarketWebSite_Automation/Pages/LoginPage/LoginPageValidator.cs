using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.LoginPage
{
   public class LoginPageValidator : BasePageValidator<LoginPageElementMap>
    {
        public void VerifyLoginPopUpIsDisplayed()
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tm-login/div//h2")));
            Assert.True(Map.LoginPopup.Displayed);
        }

        public void VerifyLoginPopUpSizeIsCorrect()
        {
            int actualHeight = Map.LoginPopup.Size.Height;
            int actualWidth = Map.LoginPopup.Size.Width;
            Assert.AreEqual(360, actualHeight, $"Expected height of Login PopUp is 360, but it was {actualHeight}");
            Assert.AreEqual(355, actualWidth, $"Expected width of Login PopUp is 355, but it was {actualWidth}");
        }

        public void VerifyLoginPopUpHeader()
        {
            Assert.True(Map.HeaderOfLoginPopUp.Displayed);            
            Assert.AreEqual("Вход в сайта на Техномаркет", Map.HeaderOfLoginPopUp.Text);           
        }

        public void VerifyEmailInputFieldIsDisplayd()
        {           
            Assert.True(Map.EmailInputField.Displayed, "Email Input Field is not displayed on the Login page");
        }

        public void VerifyEmailInputFieldIsClickable()
        {
            Assert.True(Map.EmailInputField.Enabled, "Email Input Field is not clickable on the Login page");
        }
        public void VerifyEmailIconIsDisplayd()
        {
            Assert.True(Map.EmailIcon.Displayed, "Email Icon is not displayed on the Login page");
        }

        public void VerifyPasswordInputFieldIsDisplayd()
        {
            Assert.True(Map.PasswordInputField.Displayed, "Password Input Field is not displayed on the Login page");
        }

        public void VerifyPasswordInputFieldIsClickable()
        {
            Assert.True(Map.PasswordInputField.Enabled, "Password Input Field is not clickable on the Login page");
        }

        public void VerifyLockIconIsDisplayd()
        {
            Assert.True(Map.LockIcon.Displayed, "Lock Icon is not displayed on the Login page");
        }

        public void VerifyLoginButtonIsDisplayd()
        {
            Assert.True(Map.LoginButtonOnLoginPopUp.Displayed, "Login button is not displayed on the Login page");
        }

        public void VerifyRegistrationButtonIsDisplayd()
        {
            Assert.True(Map.RegistrationButton.Displayed, "Registration button is not displayed on the Login page");
        }

        public void VerifyForgottenPasswordButtonIsDisplayd()
        {
            Assert.True(Map.ForgottenPasswordButton.Displayed, "ForgottenPassword button is not displayed on the Login page");
        }

        public void VerifyLoginButtonIsNotClickable()
        {
            string IsDisabled = Map.LoginButtonOnLoginPopUp.GetAttribute("disabled");
            Assert.AreEqual("true", IsDisabled,"LoginButtonIsClickable");
        }

        public void VerifyLoginButtonIsGrey()
        {
            string color = Map.LoginButtonOnLoginPopUp.GetCssValue("color");
            Assert.AreEqual("rgba(0, 0, 0, 0.26)", color, "LoginButtonIsNotGrey");
        }

        public void VerifyLoginButtonIsRed()
        {
            string color = Map.LoginButtonOnLoginPopUp.GetCssValue("color");
            Assert.AreEqual("rgba(255, 255, 255, 1)", color, "LoginButtonIsNotGrey");
        }

        public void VerifyLoginButtonIsClickable()
        {
            string IsDisabled = Map.LoginButtonOnLoginPopUp.GetAttribute("disabled");
            Assert.AreEqual(null, IsDisabled, "LoginButtonIsNotClickable");
        }


        public void VerifyRegistrationButtonIsClickable()
        {
            Assert.True(Map.RegistrationButton.Enabled);
            string IsDisabled = Map.RegistrationButton.GetAttribute("disabled");
            Assert.AreEqual(null, IsDisabled);
        }

        public void VerifyForgottenPasswordButtonIsClickable()
        {
            Assert.True(Map.ForgottenPasswordButton.Enabled);
            string IsDisabled = Map.ForgottenPasswordButton.GetAttribute("disabled");
            Assert.AreEqual(null, IsDisabled);
        }


        public void VerifyEmailInputFieldIsActive()
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            Assert.AreEqual(Map.EmailInputField, activeElement, "Email input field is not active");
        }

        public void VerifyPasswordInputFieldIsActive()
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            Assert.AreEqual(Map.PasswordInputField, activeElement, "Password input field is not active");
        }

        public void VerifyRegistrationButtonIsActive()
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            Assert.AreEqual(Map.RegistrationButton, activeElement, "Register button is not active");
        }
        public void VerifyForgottenPasswordButtonIsActive()
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            Assert.AreEqual(Map.ForgottenPasswordButton, activeElement, "Forgotten password button is not active");
        }


        public void VerifyLoginButtonIsActive()
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            Assert.AreEqual(Map.LoginButtonOnLoginPopUp, activeElement, "Login Button is not active");
        }

        public void VerifyProperErrorMessageIsDisplayed()
        {            
            Assert.True(Map.ErrorMessageOnLoginPage.Displayed, "Error message is not displayed when login is not successful");
            Assert.AreEqual("Възникна грешка", Map.ErrorMessageOnLoginPage.Text, "Incorrect text of error message");
        }



    }
}
