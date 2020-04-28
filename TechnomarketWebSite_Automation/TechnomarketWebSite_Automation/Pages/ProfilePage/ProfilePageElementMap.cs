using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.ProfilePage
{
    public class ProfilePageElementMap : BasePageElementMap
    {

        public IWebElement ExitButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-profile//span[text()[contains(.,'Изход')]]"));
            }
        }

        public IWebElement ChangePasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//a/span[text()[contains(.,'Изберете нова парола')]]"));
            }
        }

        public IWebElement ChangePasswordPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-change-password-dialog/.."));
            }
        }


        public IWebElement CurrentPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-change-password-dialog//input[@placeholder='Текуща парола']"));
            }
        }

        public IWebElement NewPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-change-password-dialog//input[@placeholder='Нова парола']"));
            }
        }

        public IWebElement ConfirmNewPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-change-password-dialog//input[@placeholder='Потвърди нова парола']"));
            }
        }

        public IWebElement SaveNewPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-change-password-dialog//button/span[text()[contains(.,'Запиши')]]/.."));
            }
        }
    }
}
