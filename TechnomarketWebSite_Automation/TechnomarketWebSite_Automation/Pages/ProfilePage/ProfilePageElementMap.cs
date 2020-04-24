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
    }
}
