using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Factories;
using TechnomarketWebSite_Automation.Models;
using TechnomarketWebSite_Automation.Pages.LoginPage;
using TechnomarketWebSite_Automation.Pages.MainPage;
using TechnomarketWebSite_Automation.Pages.ProfilePage;
using TechnomarketWebSite_Automation.Pages.RegistrationPage;

namespace TechnomarketWebSite_Automation.Core
{
     public class BaseTests
    {
        protected MainPage mainPage;
        protected LoginPage loginPage;
        protected RegistrationPage registrationPage;
        protected ProfilePage profilePage;
        protected UserFactory userFactory;
        protected User registeredUser;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
           /* Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            this.mainPage = new MainPage();
            this.profilePage = new ProfilePage();
            this.registrationPage = new RegistrationPage();
            this.userFactory = new UserFactory();
            this.registeredUser = userFactory.CreateUser("male", true);
            this.registrationPage.NavigateToRegistrationPage();
            this.registrationPage.RegisterUser(registeredUser);
            this.profilePage.Logout();
            Driver.StopBrowser();*/
        }

        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();
            Driver.Browser.Manage().Window.Maximize();
            this.mainPage = new MainPage();
            this.loginPage = new LoginPage();
            this.profilePage = new ProfilePage();
            this.registrationPage = new RegistrationPage();
            this.userFactory = new UserFactory();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}
