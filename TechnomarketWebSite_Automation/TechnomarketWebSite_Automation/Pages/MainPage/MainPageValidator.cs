using TechnomarketWebSite_Automation.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TechnomarketWebSite_Automation.Pages.MainPage
{
    public class MainPageValidator : BasePageValidator<MainPageElementMap>
    {

        public void VeifyTitleOfMainPage(string mainPageTitle)
        {            
            Assert.AreEqual("Техномаркет - онлайн магазин | Начална страница", mainPageTitle);
        }

        public void VerifyLogoIsDisplayedOnTheMainPage()
        {
            Assert.True(this.Map.TehnomarketLogoOnTheMainPage.Displayed);
        }
    }
}
