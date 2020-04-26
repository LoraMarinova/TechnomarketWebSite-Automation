using TechnomarketWebSite_Automation.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
            Driver.BrowserWait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//tm-login/div/../..")));
            Assert.True(this.Map.ProfileButton.Displayed);
        }

        public void VerifyProfileUserIsLoggedIn(string email)
        {
            Assert.AreEqual(email + "person", Map.ProfileButton.Text);
        }

        public void VerifyLoginButtonIsNotDisplayed()
        {
            Thread.Sleep(1000);
            Assert.That(() => this.Map.LoginButton,
                Throws.Exception.With.Message.Contains("no such element: Unable to locate element:"));
        }

        public void VerifyProfileButtonIsNotDisplayed()
        {
            Thread.Sleep(1000);
            //Assert.True(Map.ProfileButton.Displayed);
            Assert.That(() => Map.ProfileButton,
            Throws.Exception.With.Message.Contains("no such element: Unable to locate element:"));
        }
    }
}
