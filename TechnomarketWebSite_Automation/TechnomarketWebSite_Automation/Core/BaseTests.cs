using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Pages.MainPage;

namespace TechnomarketWebSite_Automation.Core
{
     public class BaseTests
    {
        protected MainPage mainPage;
         
        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            this.mainPage = new MainPage();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}
