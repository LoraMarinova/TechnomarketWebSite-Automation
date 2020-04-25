using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.ForgottenPasswordPage
{
    public class ForgottenPasswordPageElememntMap : BasePageElementMap
    {
        public IWebElement ForgottenPasswordPopup
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-password-restore/.."));
            }
        }

        public IWebElement ForgottenPasswordPopupHeader
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//tm-password-restore//h2"));
            }
        }
    }
}
