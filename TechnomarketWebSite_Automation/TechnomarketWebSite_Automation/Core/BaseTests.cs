using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System;
using TechnomarketWebSite_Automation.Core.Utilities;
using TechnomarketWebSite_Automation.Factories;
using TechnomarketWebSite_Automation.Models;
using TechnomarketWebSite_Automation.Pages.ForgottenPasswordPage;
using TechnomarketWebSite_Automation.Pages.LoginPage;
using TechnomarketWebSite_Automation.Pages.MainPage;
using TechnomarketWebSite_Automation.Pages.ProfilePage;
using TechnomarketWebSite_Automation.Pages.RegistrationPage;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;
using System.IO;

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
        protected ForgottenPasswordPage forgottenPasswordPage;
        protected RandomValuesGenerator randomGenerator;
        private const string dateTimeFormatSeconds = "ddMMyy-HHmmss";
        protected string dateTimeNow;

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
            this.forgottenPasswordPage = new ForgottenPasswordPage();
            this.userFactory = new UserFactory();
            this.randomGenerator = new RandomValuesGenerator();
            this.dateTimeNow = DateTime.Now.ToString(dateTimeFormatSeconds);

        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Directory.CreateDirectory("ScreenSohotsFailedTests");
                string screensLocation = @"ScreenSohotsFailedTests\";
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)Driver.Browser).GetScreenshot();
                screenshot.SaveAsFile(screensLocation + testName + ".png");               
            }
            Driver.StopBrowser();
        }
    }
}
