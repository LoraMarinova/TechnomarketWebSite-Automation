using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Threading;
using System.Reflection;
using TechnomarketWebSite_Automation.Core;
using TechnomarketWebSite_Automation.Pages.MainPage;

namespace TechnomarketWebSite_Automation
{
    [TestFixture]
    public class MainPageTests
    {
       

        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();
           
        }

        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }

        [Test]
        public void VerifyMainPageTitle()
        {
            MainPage mainPage = new MainPage();
            mainPage.Navigate();
            string mainPageTitle = mainPage.GetTitleOfPage();
            mainPage.Validate().VeifyTitleOfMainPage(mainPageTitle);
        }

        [Test]
        public void VerifyLogoIsPresentedOnTheMainPage()
        {
            MainPage mainPage = new MainPage();
            mainPage.Navigate();
            mainPage.Validate().VerifyLogoIsDisplayedOnTheMainPage();
        }
    }
}
