using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;
using NUnit.Framework;
using TechnomarketWebSite_Automation.Models;
using TechnomarketWebSite_Automation.Factories;
using System.Threading;
using NUnit.Framework.Interfaces;
using System.IO;
using OpenQA.Selenium;

namespace TechnomarketWebSite_Automation.Tests
{
    public class LoginPageTests : BaseTests
    {
        //Use constructor till writing tests, when run entire suite commentthe constructor 
        //and use OneTimeSetUo user
        public LoginPageTests()
        {
            this.registeredUser = new User();
            this.registeredUser.Email = "abcd@yopmail.com";
            this.registeredUser.Password = "123456";
            this.registeredUser.Salutation = "Господин";
            this.registeredUser.FirstName = "abcdfirst";
            this.registeredUser.LastName = "abcdfirst";
            this.registeredUser.Birthdate = "9.02.1994";
            this.registeredUser.ResivePromotionInfo = true;
            this.registeredUser.AgreeToProcessPersonalData = true;
            this.registeredUser.AcceptTerms = true;
        }

        [Test]
        public void VerifyUserCanAccessLoginPage()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
        }

        [Test]
        public void VerifySizeOfLoginPagePopUp()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyLoginPopUpSizeIsCorrect();
        }

        [Test]
        public void VerifyHeaderOfLoginPage()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyLoginPopUpHeader();
        }

        [Test]
        public void VerifyRequiredElementsAreDisplayedOnLoginPage()
        {
            loginPage.NavigateToLoginPage();

            loginPage.Validate().VerifyEmailInputFieldIsDisplayd();
            loginPage.Validate().VerifyEmailIconIsDisplayd();
            loginPage.Validate().VerifyPasswordInputFieldIsDisplayd();
            loginPage.Validate().VerifyLockIconIsDisplayd();
            loginPage.Validate().VerifyLoginButtonIsDisplayd();
            loginPage.Validate().VerifyRegistrationButtonIsDisplayd();
            loginPage.Validate().VerifyForgottenPasswordButtonIsDisplayd();
        }

        [Test]
        public void VerifyEmailAndPasswordInputFieldsAreClickable()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyEmailInputFieldIsClickable();
            loginPage.Validate().VerifyPasswordInputFieldIsClickable();
        }

        [Test]
        public void VerifyIfEmailAndPasswordFieldsAreEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }

        [Test]
        public void VerifyIfEmailFieldIsEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }

        [Test]
        public void VerifyIfPasswordFieldIsEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypePassword(registeredUser.Password);
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }
    
        [Test]
        public void VerifyIfEmailAndPasswordFieldsAreFilledLoginButtonIsClickableAndRed()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.Validate().VerifyLoginButtonIsClickable();
            loginPage.Validate().VerifyLoginButtonIsRed();
        }

        [Test]
        public void VerifyRegistrationButtonIsClickable()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyRegistrationButtonIsClickable();
        }

        [Test]
        public void VerifyForgottenButtonIsClickable()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyRegistrationButtonIsClickable();
        }

        [Test]
        public void VerifyWhenUserOpenLoginPageTheCursorIsInEmailInputField()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
        }          
            

        [Test]
        public void VerifyUserCanNavigateThrowghtTheLoginPageUsingTabAndShiftKeys()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyPasswordInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyRegistrationButtonIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyForgottenPasswordButtonIsActive();
            loginPage.PressTabPlusShiftKeys();
            loginPage.Validate().VerifyRegistrationButtonIsActive();
            loginPage.PressTabPlusShiftKeys();
            loginPage.Validate().VerifyPasswordInputFieldIsActive();
            loginPage.PressTabPlusShiftKeys();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
        }


        [Test]
        public void VerifyUserCanNavigateThrowghtTheLoginPageUsingTabAndEnterKeys()
        {
            loginPage.NavigateToLoginPage();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyPasswordInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyRegistrationButtonIsActive();
            loginPage.PressEnterKey();
            registrationPage.Validate().VerifyRegistrationPopUpIsDisplayed();
            loginPage.NavigateBack();
            Thread.Sleep(1000);
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyPasswordInputFieldIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyRegistrationButtonIsActive();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyForgottenPasswordButtonIsActive();
            loginPage.PressEnterKey();
            forgottenPasswordPage.Validate().VerifyForgottenPasswordPopUpIsDisplayed();
        }

        [Test]
        public void VerifyUserCanLoginNavigatingOnlyWihtKeys()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeInActiveField(registeredUser.Email);
            loginPage.PressTabKey();
            loginPage.TypeInActiveField(registeredUser.Password);
            loginPage.PressTabKey();
            loginPage.Validate().VerifyLoginButtonIsActive();
            loginPage.PressEnterKey();
            mainPage.Validate().VerifyProfileButtonIsDisplayed();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
        }

        [Test]
        public void VerifyUserCanLoginSuccessfullyWithCorrectEmailAndPasswordAndUserAccountIsDisplayed()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileButtonIsDisplayed();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
        }

        [Test]
        public void VerifyWhenUserIsLogedLoginButtonIsNoLongerDisplayed()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyLoginButtonIsNotDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithNotExistingEmailAndPassword()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(randomGenerator.GenerateEmail(dateTimeNow));
            loginPage.TypePassword(randomGenerator.GeneratePassword(dateTimeNow));
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithExistingEmailAndWrongPassword()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(randomGenerator.GeneratePassword(dateTimeNow));
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithExistingEmailAndPasswordContainingOnlyWiteSpaces()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword("   ");
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithNotExistingEmailAndPasswordOfRegisteredUser()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(randomGenerator.GenerateEmail(dateTimeNow));
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithEmailContainingOnlyWhiteSpacesAndPasswordOfRegisteredUser()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail("   ");
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithEmailAndPasswordBothContainingOnlyWhiteSpaces()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail("   ");
            loginPage.TypePassword("   ");
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyLoginPageIsLoadedUnderFiveSecondsWhenUserOpenItDirectly()
        {
            stopWatch.Start();
            loginPage.NavigateToLoginPage();
            stopWatch.Stop();
            long actualMiliseconds = stopWatch.ElapsedMilliseconds;
            loginPage.Validate().VerifyPageIsLoadedUnderRequiredSeconds(5000, actualMiliseconds);
        }

        [Test]
        public void VerifyLoginPageIsLoadedUnderFourSecondsWhenUserOpenItFromMainPage()
        {
            mainPage.Navigate();
            stopWatch.Start();
            mainPage.GoToLogin();
            stopWatch.Stop();
            long actualMiliseconds = stopWatch.ElapsedMilliseconds;
            loginPage.Validate().VerifyPageIsLoadedUnderRequiredSeconds(4000, actualMiliseconds);
        }

        [Test]
        public void VerifyUserCanlogout()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.GoToProfile();
            profilePage.Logout();
            Thread.Sleep(1000);
            mainPage.Validate().VerifyProfileButtonIsNotDisplayed();
        }

        [Test]
        public void VerifyAfterUserIslogedOutLoginButtonIsDisplayed()
        {
            loginPage.NavigateToLoginPage();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.GoToProfile();
            profilePage.Logout();
            Thread.Sleep(1000);
            mainPage.Validate().VerifyLoginButtonIsDisplayedOnTheMainPage();
        }
    }
}
