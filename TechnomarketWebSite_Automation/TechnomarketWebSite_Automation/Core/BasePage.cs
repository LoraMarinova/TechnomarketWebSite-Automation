
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechnomarketWebSite_Automation.Enums;

namespace TechnomarketWebSite_Automation.Core
{
    public class BasePage<M>
       where M : BasePageElementMap, new()
    {
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }

        protected M Map
        {
            get
            {
                return new M();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }

    public class BasePage<M, V> : BasePage<M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public BasePage(string url)
            : base(url)
        {
        }

        public V Validate()
        {
            return new V();
        }

        public string GetTitleOfPage()
        {
            return Driver.Browser.Title;
        }

        
        
    }

}
