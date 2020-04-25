
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechnomarketWebSite_Automation.Enums;

namespace TechnomarketWebSite_Automation.Core
{
    public class BasePage<M>
       where M : BasePageElementMap, new()
    {
        protected readonly string url;
        protected Actions action;
        protected IJavaScriptExecutor js;

        public BasePage()
        {
            this.action = new Actions(Driver.Browser);
            this.js = ((IJavaScriptExecutor)Driver.Browser);
        }
        public BasePage(string url)
            :this()
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

        public void Type(IWebElement inputField, string text)
        {
            inputField.Clear();
            inputField.SendKeys(text);
        }

        public void SelectFromDropdown(IWebElement dropdown, string text)
        {
            SelectElement salutation = new SelectElement(dropdown);
            salutation.SelectByText(text);
        }

        public void SelectCheckBox(IWebElement checkBox)
        {
            if (!checkBox.Selected)
            {
                checkBox.Click();
            }
        }

        public void ClearCheckBox(IWebElement checkBox)
        {
            if (checkBox.Selected)
            {
                checkBox.Click();
            }
        }
        public void Click(IWebElement element)
        {
            element.Click();
        }

        public void NavigateBack()
        {
            Driver.Browser.Navigate().Back();
        }







    }

}
