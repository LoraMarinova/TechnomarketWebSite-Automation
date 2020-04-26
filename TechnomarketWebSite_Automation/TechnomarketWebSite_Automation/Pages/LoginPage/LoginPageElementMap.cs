using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.LoginPage
{
    public class LoginPageElementMap : BasePageElementMap
    {

        public IWebElement LoginPopup
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div/../.."));
            }
        }

        public IWebElement RegistrationButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//span[ text()[contains(.,'Регистрация')]]/.."));                
            }
        }

        public IWebElement ForgottenPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//span[ text()[contains(.,'Забравена парола')]]/.."));
            }
        }

        public IWebElement LoginButtonOnLoginPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//button/span[ text()[contains(.,'Вход')]]/.."));
            }
        }

        public IWebElement EmailInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div/../..//tm-login/div//input[@formcontrolname='email']"));
            }
        }

        public IWebElement EmailIcon
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//mat-icon[text()[contains(.,'email')]]"));
            }
        }

        public IWebElement LockIcon
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//mat-icon[text()[contains(.,'lock')]]"));
            }
        }

        public IWebElement PasswordInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//input[@formcontrolname='password']"));
            }
        }

        public IWebElement HeaderOfLoginPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//h2"));
            }
        }

        public IWebElement ErrorMessageOnLoginPage
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//div[@class='error ng-star-inserted']"));
            }
        }
    }
}
