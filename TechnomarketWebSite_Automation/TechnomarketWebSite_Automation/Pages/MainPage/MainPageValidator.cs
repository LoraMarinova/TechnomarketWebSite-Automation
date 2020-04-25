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

        public void VerifyProfileButtonIsDisplayed()
        {
            Assert.True(this.Map.ProfileButton.Displayed);
        }

        public void VerifyProfileUserIsLoggedIn(string email)
        {
            Assert.AreEqual(email+"person", Map.ProfileButton.Text);
        }
    }
}
