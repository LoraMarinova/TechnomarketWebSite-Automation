using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TechnomarketWebSite_Automation.Core
{
    public class BasePageElementMap
    {
        protected IWebDriver browser;
        protected WebDriverWait browserWait;
        public BasePageElementMap()
        {
            this.browser = Driver.Browser;
            this.browserWait = Driver.BrowserWait;
        }       

        public void SwitchToDefault()
        {
            browser.SwitchTo().DefaultContent();
        }
    }
}
