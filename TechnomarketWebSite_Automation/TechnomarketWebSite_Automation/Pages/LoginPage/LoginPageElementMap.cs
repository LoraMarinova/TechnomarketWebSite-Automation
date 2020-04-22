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
                    ("//tm-login/div"));
            }
        }

        public IWebElement RegistrationButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//span[ text()[contains(.,'Регистрация')]]"));
            }
        }

        public IWebElement ForgottenPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//span[ text()[contains(.,'Забравена парола')]]"));
            }
        }

        public IWebElement LoginButtonInLoginPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//span[ text()[contains(.,'Вход')]]"));
            }
        }

        public IWebElement EmailInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//input[@formcontrolname='email']"));
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

        public IWebElement TitleOfLoginPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-login/div//h2"));
            }
        }
    }
}
