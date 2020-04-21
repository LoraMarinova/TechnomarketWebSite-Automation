using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace TechnomarketWebSite_Automation.Core
{
    public static class Driver
    {
        private static WebDriverWait browserWait;
        private static IWebDriver browser;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set
            {
                browser = value;
            }
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (browserWait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return browserWait;
            }
            private set
            {
                browserWait = value;
            }
        }

        public static void StartBrowser(BrowserTypes browserType = BrowserTypes.Chrome, int defaultTime = 20)
        {
            switch (browserType)
            {
                case BrowserTypes.Firefox:
                    break;
                case BrowserTypes.InternetExplorer:
                    break;
                case BrowserTypes.Chrome:
                    Browser = new ChromeDriver();
                    break;
                default:
                    break;
            }
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTime));
            Browser.Manage().Window.Maximize();
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
