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
    public class MainPageTests : BaseTests
    { 
        [Test]
        public void VerifyMainPageTitle()
        {            
            mainPage.Navigate();
            string mainPageTitle = mainPage.GetTitleOfPage();
            mainPage.Validate().VeifyTitleOfMainPage(mainPageTitle);
        }

        [Test]
        public void VerifyLogoIsPresentedOnTheMainPage()
        {           
            mainPage.Navigate();
            mainPage.Validate().VerifyLogoIsDisplayedOnTheMainPage();
        }
    }
}
