using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.LoginPage
{
   public class LoginPageValidator : BasePageValidator<LoginPageElementMap>
    {
        public void VerifyLoginPopUpIsDisplayed()
        {
            Assert.True(Map.LoginPopup.Displayed);
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
    }
}
