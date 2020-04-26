using OpenQA.Selenium;
using System;

using TechnomarketWebSite_Automation.Core;

namespace TechnomarketWebSite_Automation.Pages.MainPage
{
    public class MainPageElementMap : BasePageElementMap
    {
        public IWebElement LoginButton
        {
            get
            {
                return browser.FindElement(By.XPath
                    ("//span[text()[contains(.,'Вход')]]/../.."));
            }
        }

        public IWebElement CartButton
        {
            get
            {
                return browser.FindElement(By.XPath("//a[@class ='mat-button mat-button-base ng-star-inserted']//span[text()[contains(.,'Количка')]]/../.."));
            }
        }

        public IWebElement TehnomarketLogoOnTheMainPage
        {
            get
            {
                return browser.FindElement(By.XPath("//tm-logo//img[@alt='Техномаркет']"));
            }
        }

        public IWebElement ProfileButton
        {
            get
            {
                return browser.FindElement(By.XPath("//a[@routerlink='/profile']"));
            }
        }
    }
}
