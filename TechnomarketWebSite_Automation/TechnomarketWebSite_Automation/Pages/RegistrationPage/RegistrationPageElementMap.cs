using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.RegistrationPage
{
    public class RegistrationPageElementMap : BasePageElementMap
    {
        public IWebElement RegistrationPopUp
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div"));
            }
        }
        public IWebElement EmailInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//input[@formcontrolname='email']"));
            }
        }
        public IWebElement PasswordInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//input[@formcontrolname='password']"));
            }
        }
        public IWebElement SalutationDropDown
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//mat-select[@placeholder='Обръщение']/div"));
            }
        }
        public IWebElement SalutationMr
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//span[text()[contains(.,'Господин')]]"));
            }
        }

        public IWebElement SalutationMs
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//span[text()[contains(.,'Госпожа')]]"));
            }
        }

        public IWebElement FirstNameInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//input[@formcontrolname='firstName']"));
            }
        }
        public IWebElement LastNameInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//input[@formcontrolname='lastName']"));
            }
        }

        public IWebElement BirthDateInputField
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//input[@formcontrolname='birthday']"));
            }
        }

        public IWebElement ResivePromotionInfoCheckBox
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//span[text()[contains" +
                    "(.,'Искам да получавам информация за промоции и нови продукти')]]/..//div[@class='mat-checkbox-inner-container']"));
            }
        }

        public IWebElement AgreeToProcessPersonalDataCheckBox
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//span[text()[contains" +
                    "(.,'Ние имаме нужда от Вашето съгласие, за да обработваме личните Ви данни')]]/..//div[@class='mat-checkbox-inner-container']"));
            }
        }

        public IWebElement AcceptTermsCheckBox
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//span[text()[contains" +
                    "(.,'Приемам условията за ползване')]]/..//div[@class='mat-checkbox-inner-container']"));
            }
        }

        public IWebElement RegistrationButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//button//span[text()[contains(.,'Регистрация')]]"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//span[text()[contains(.,'Вход')]]"));
            }
        }

        public IWebElement ForgottenPasswordButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//span[text()[contains(.,'Забравена парола')]]"));
            }
        }

        public IWebElement RegistrationPopUpTitle
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-register/div//h2"));
            }
        }
    }
}
