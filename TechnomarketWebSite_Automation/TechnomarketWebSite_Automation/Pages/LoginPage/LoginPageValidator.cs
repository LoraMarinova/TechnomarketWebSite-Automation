using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechnomarketWebSite_Automation.Core;
using System.Windows;

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
            Assert.AreEqual("true", IsDisabled, "LoginButtonIsClickable");
        }

        public void VerifyLoginButtonIsGrey()
        {
            string color = Map.LoginButtonOnLoginPopUp.GetCssValue("background-color");
            Assert.AreEqual("rgba(0, 0, 0, 0.12)", color, "LoginButtonIsNotGrey");
        }

        public void VerifyLoginButtonIsNotGrey()
        {
            string color = Map.LoginButtonOnLoginPopUp.GetCssValue("background-color");
            Assert.AreNotEqual("(rgba(0, 0, 0, 0.12)", color, "LoginButtonIsNotRed");
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
            Thread.Sleep(1000);
            Assert.True(Map.ErrorMessageOnLoginPage.Displayed, "Error message is not displayed when login is not successful");
            Assert.AreEqual("Възникна грешка", Map.ErrorMessageOnLoginPage.Text, "Incorrect text of error message");
        }

        //Doesn't work
        public void VerifyLineUnderEmailInputFieldIsBold()
        {
            var style = Map.LineUnderEmailInputField.GetCssValue("overflow-x");
            Assert.AreEqual("block", style);
        }
        //Doesn't work
        public void VerifyLineUnderPasswordInputFieldIsNotBold()
        {
            var style = Map.LineUnderPasswordInputField.GetCssValue("display");
            Assert.AreEqual("block", style);
        }

        public void VerifyRegistrationButtonIsWhite()
        {
            Assert.AreEqual("rgba(0, 0, 0, 0)", Map.RegistrationButton.GetCssValue("background-color"));
        }

        public void VerifyForgottenPasswordButtonIsWhite()
        {
            Assert.AreEqual("rgba(0, 0, 0, 0)", Map.ForgottenPasswordButton.GetCssValue("background-color"));
        }


        //Doesn't work
        public void VerifyRegistrationButtonIsGrey()
        {
            Assert.AreEqual("rgba(0, 0, 0, 0.26)", Map.RegistrationButton.GetCssValue("background-color"));
        }

        //Doesn't work
        public void VerifyForgottenPasswordButtonIsGrey()
        {
            Assert.AreEqual("rgba(0, 0, 0, 0.26)", Map.ForgottenPasswordButton.GetCssValue("background-color"));
        }

        public void VerifyEmailInputFieldPlaceholderIsValid()
        {
            string palceholder = Map.EmailInputField.GetAttribute("placeholder");
            Assert.AreEqual("Адрес на електронна поща", palceholder);
        }

        public void VerifyPasswordInputFieldPlaceholderIsValid()
        {
            string palceholder = Map.PasswordInputField.GetAttribute("placeholder");
            Assert.AreEqual("Парола", palceholder);
        }

        public void VerifyEmailInputFieldLableIsValid()
        {           
            Assert.AreEqual("Адрес на електронна поща *", Map.FieldArroundEmailInputField.Text);
        }

        public void VerifyPasswordInputFieldLableIsValid()
        {            
            Assert.AreEqual("Парола *", Map.FieldArroundPasswordInputField.Text);
        }

        public void VerifyPasswordIsEncryptedWhenItIsEntered()
        {
            string value = Map.PasswordInputField.GetAttribute("value");
            Assert.AreEqual("*****************", value);
        }

        public void VerifyPasswordInputFieldIsPasswordType()
        {
            string type = Map.PasswordInputField.GetAttribute("type");
            Assert.AreEqual("password", type);
        }

        public void VerifyEmailIsNotEncryptedWhenItIsEntered(string text)
        {
            string value = Map.EmailInputField.GetAttribute("value");
            Assert.AreEqual(text, value);
        }

        public void VerifyLoginPopupIsNotDisplayed()
        {
            Thread.Sleep(1000);
            Assert.That(() => this.Map.LoginPopup,
                Throws.Exception.With.Message.Contains("no such element: Unable to locate element:"));
        }

        

    }
}
