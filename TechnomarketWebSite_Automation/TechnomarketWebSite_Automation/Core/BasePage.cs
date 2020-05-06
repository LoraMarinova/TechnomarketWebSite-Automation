
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TechnomarketWebSite_Automation.Enums;
using System.Reflection;
using System;
using System.Linq;

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

        public void Refresh()
        {
            Driver.Browser.Navigate().Refresh();
            Driver.BrowserWait.Until(driver1 => ((IJavaScriptExecutor)Driver.Browser).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public void OpenNewWindow()
        {
            js.ExecuteScript("window.open(arguments[0])", this.url);            
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
            string id = inputField.GetAttribute("id");
            Driver.BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.Id(id)));
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
            Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(checkBox));
            if (!checkBox.Selected)
            {
                checkBox.Click();
            }
        }

        public void ClearCheckBox(IWebElement checkBox)
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(checkBox));
            if (checkBox.Selected)
            {
                checkBox.Click();
            }
        }
        public void Click(IWebElement element)
        {
            Driver.BrowserWait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void NavigateBack()
        {
            Driver.Browser.Navigate().Back();
        }

        public void TypeInActiveField(string text)
        {
            IWebElement activeElement = Driver.Browser.SwitchTo().ActiveElement();
            activeElement.SendKeys(text);
        }
    }
}
