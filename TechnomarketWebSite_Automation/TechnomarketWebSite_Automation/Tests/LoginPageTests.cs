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
using System.Linq;

namespace TechnomarketWebSite_Automation.Tests
{
    public class LoginPageTests : BaseTests
    {
        //Use constructor till writing tests, when run entire suite comment the constructor 
        //and use OneTimeSetUo user
       /* public LoginPageTests()
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
        }*/

        [Test]
        public void VerifyUserCanAccessLoginPage()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
        }

        [Test]
        public void VerifySizeOfLoginPagePopUp()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginPopUpSizeIsCorrect();
        }

        [Test]
        public void VerifyHeaderOfLoginPage()
        {
            loginPage.Navigate();
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginPopUpHeader();
        }

        [Test]
        public void VerifyRequiredElementsAreDisplayedOnLoginPage()
        {
            loginPage.Navigate();

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
            loginPage.Navigate();
            loginPage.Validate().VerifyEmailInputFieldIsClickable();
            loginPage.Validate().VerifyPasswordInputFieldIsClickable();
        }

        [Test]
        public void VerifyIfEmailAndPasswordFieldsAreEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }

        [Test]
        public void VerifyIfEmailFieldIsEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }

        [Test]
        public void VerifyIfPasswordFieldIsEmptyLoginButtonIsNotClickableAndGrey()
        {
            loginPage.Navigate();
            loginPage.TypePassword(registeredUser.Password);
            loginPage.Validate().VerifyLoginButtonIsNotClickable();
            loginPage.Validate().VerifyLoginButtonIsGrey();
        }

        [Test]
        public void VerifyIfEmailAndPasswordFieldsAreFilledLoginButtonIsClickableAndRed()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.Validate().VerifyLoginButtonIsClickable();
            loginPage.Validate().VerifyLoginButtonIsNotGrey();
        }

        [Test]
        public void VerifyRegistrationButtonIsClickable()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyRegistrationButtonIsClickable();
        }

        [Test]
        public void VerifyForgottenButtonIsClickable()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyRegistrationButtonIsClickable();
        }

        [Test]
        public void VerifyWhenUserOpenLoginPageTheCursorIsInEmailInputField()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyEmailInputFieldIsActive();
        }


        [Test]
        public void VerifyUserCanNavigateThrowghtTheLoginPageUsingTabAndShiftKeys()
        {
            loginPage.Navigate();
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
            loginPage.Navigate();
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
        public void VerifyUserCanLoginNavigatingOnlyByKeys()
        {
            loginPage.Navigate();
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
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileButtonIsDisplayed();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
        }

        [Test]
        public void VerifyWhenUserIsLogedLoginButtonIsNoLongerDisplayed()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyLoginButtonIsNotDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithNotExistingEmailAndPassword()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(randomGenerator.GenerateEmail(dateTimeNow));
            loginPage.TypePassword(randomGenerator.GeneratePassword(dateTimeNow));
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithExistingEmailAndWrongPassword()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(randomGenerator.GeneratePassword(dateTimeNow));
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithExistingEmailAndPasswordContainingOnlyWiteSpaces()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword("   ");
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithNotExistingEmailAndPasswordOfRegisteredUser()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(randomGenerator.GenerateEmail(dateTimeNow));
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithEmailContainingOnlyWhiteSpacesAndPasswordOfRegisteredUser()
        {
            loginPage.Navigate();
            loginPage.TypeEmail("   ");
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithEmailAndPasswordBothContainingOnlyWhiteSpaces()
        {
            loginPage.Navigate();
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
            loginPage.Navigate();
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
            loginPage.Navigate();
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
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.GoToProfile();
            profilePage.Logout();
            Thread.Sleep(1000);
            mainPage.Validate().VerifyLoginButtonIsDisplayedOnTheMainPage();
        }

        [Test]
        public void VerifyNotActiveInputFildsHaveValidPlaceHolders()
        {
            loginPage.Navigate();
            loginPage.PressTabKey();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyEmailInputFieldPlaceholderIsValid();
            loginPage.Validate().VerifyEmailInputFieldLableIsValid();
            loginPage.Validate().VerifyPasswordInputFieldPlaceholderIsValid();
            loginPage.Validate().VerifyPasswordInputFieldLableIsValid();
        }

        [Test]
        public void VerifyActiveInputFildsHaveValidLables()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyEmailInputFieldLableIsValid();
            loginPage.PressTabKey();
            loginPage.Validate().VerifyPasswordInputFieldLableIsValid();
        }

        [Test]
        public void VerifyPasswordInputFieldIsTypePassword()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyPasswordInputFieldIsPasswordType();            
        }

        [Test]
        public void VerifyUserCanCloseLoginPopupWithEscapeKey()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.PressEscapeKey();
            loginPage.Validate().VerifyLoginPopupIsNotDisplayed();
        }

        [Test]
        public void VerifyUserCanCloseLoginPopupByClickingOnTheMainPage()
        {
            loginPage.Navigate();
            loginPage.Validate().VerifyLoginPopUpIsDisplayed();
            loginPage.ClickOnRandomPlaceOnMainPage();
            loginPage.Validate().VerifyLoginPopupIsNotDisplayed();
        }

        [Test]
        public void VerifyUserCannotLoginWithDifferentCredentialsInTheSameBrowserAtTheSameTime()
        {
            loginPage.Navigate();
            var firstTab = Driver.Browser.CurrentWindowHandle;
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            mainPage.OpenNewWindow();
            var secondTab = Driver.Browser.WindowHandles.Last();
            Driver.Browser.SwitchTo().Window(secondTab);
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            loginPage.Navigate();
            User newRegisteredUser = userFactory.CreateUser("male", true);
            registrationPage.Navigate();
            registrationPage.RegisterUser(newRegisteredUser);
            mainPage.Validate().VerifyProfileUserIsLoggedIn(newRegisteredUser.Email);
            Driver.Browser.SwitchTo().Window(firstTab);
            loginPage.Refresh();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(newRegisteredUser.Email);
        }

        [Test]
        public void VerifyIfUserIsLogedOutHeIsLoggedOutOfTheSiteInTheSameBrowserAtTheSameTime()
        {
            loginPage.Navigate();
            var firstTab = Driver.Browser.CurrentWindowHandle;
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            mainPage.OpenNewWindow();
            var secondTab = Driver.Browser.WindowHandles.Last();
            Driver.Browser.SwitchTo().Window(secondTab);
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            mainPage.GoToProfile();
            profilePage.Logout();
            mainPage.Validate().VerifyProfileButtonIsNotDisplayed();
            mainPage.Validate().VerifyLoginButtonIsDisplayedOnTheMainPage();
            Driver.Browser.SwitchTo().Window(firstTab);
            loginPage.Refresh();
            mainPage.Validate().VerifyProfileButtonIsNotDisplayed();
            mainPage.Validate().VerifyLoginButtonIsDisplayedOnTheMainPage();
        }

        [Test]
        public void VerifyByClickinBackUserIsNotLoggedInAfterSuccessfulLogOut()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            mainPage.GoToProfile();
            profilePage.Logout();
            Driver.Browser.Navigate().Back();
            mainPage.Validate().VerifyProfileButtonIsNotDisplayed();
            mainPage.Validate().VerifyLoginButtonIsDisplayedOnTheMainPage();
        }

        [Test]
        public void VerifyByClickinBackUserIsNotLoggedOutAfterSuccessfulLogin()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(registeredUser.Email);
            mainPage.Validate().VerifyLoginButtonIsNotDisplayed();
            Driver.Browser.Navigate().Back();
            loginPage.PressEscapeKey();
            mainPage.Validate().VerifyProfileButtonIsDisplayed();
            mainPage.Validate().VerifyLoginButtonIsNotDisplayed();
        }

        [Test]
        public void VerifyEmailCanBeCopyPastedFromLoginForm()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.CopyEmailFromLoginForm();
            loginPage.ClickRegistrationButton();
            registrationPage.PasteTextToEmailField();
            registrationPage.Validate().VerifyEmailInputFieldValue(registeredUser.Email);
        }


        [Test]
        public void VerifyPasswordCannotBeCopyPastedFromLofinForm()
        {
            loginPage.Navigate();
            loginPage.TypeEmail(registeredUser.Email);
            loginPage.TypePassword(registeredUser.Password);
            loginPage.CopyPasswordFromLoginForm();
            loginPage.ClickRegistrationButton();
            registrationPage.PasteTextToEmailField();
            registrationPage.Validate().VerifyPasswordIsNotCopied(registeredUser.Password);
        }

        [Test]
        public void VerifyUserIsRedirectToRegistrationPageIfRegistrationButtenIsClicked()
        {
            loginPage.Navigate();                       
            loginPage.ClickRegistrationButton();            
            registrationPage.Validate().VerifyRegistrationPopUpIsDisplayed();
            registrationPage.Validate().VerifyRegistrationPopUpHeader();
        }

        [Test]
        public void VerifyUserIsRedirectToForgottenPasswordPageIfForgottenPasswordButtenIsClicked()
        {
            loginPage.Navigate();            
            loginPage.ClickForgottenPasswordButton();
            forgottenPasswordPage.Validate().VerifyForgottenPasswordPopUpIsDisplayed();
            forgottenPasswordPage.Validate().VerifyForgottenPasswordHeader();
        }

        [Test]
        public void VerifyIfUserCannotLoginWithOldPasswordAfterChangingThePasswordAndCanLoginWithNewPassword()
        {            
            User newRegisteredUser = userFactory.CreateUser("male", true);
            registrationPage.Navigate();
            registrationPage.RegisterUser(newRegisteredUser);
            mainPage.Validate().VerifyProfileUserIsLoggedIn(newRegisteredUser.Email);
            string oldPassword = newRegisteredUser.Password;
            string newDateTimeNow = DateTime.Now.ToString(dateTimeFormatSeconds);
            string newPassword = randomGenerator.GeneratePassword(newDateTimeNow);
            newRegisteredUser.Password = newPassword;
            mainPage.GoToProfile();
            Thread.Sleep(1000);
            profilePage.ClickOnChangePasswordButton();
            profilePage.TypeInCurrentPasswordInputFields(oldPassword);
            profilePage.TypeInNewPasswordInputFields(newPassword);
            profilePage.TypeInConfirmNewPasswordInputFields(newPassword);
            profilePage.ClickOnSaveNewPassword();
            profilePage.Logout();
            mainPage.GoToLogin();
            loginPage.TypeEmail(newRegisteredUser.Email);
            loginPage.TypePassword(oldPassword);
            loginPage.ClickLoginButton();
            loginPage.Validate().VerifyProperErrorMessageIsDisplayed();
            loginPage.TypeEmail(newRegisteredUser.Email);
            loginPage.TypePassword(newPassword);
            loginPage.ClickLoginButton();
            mainPage.Validate().VerifyLoginButtonIsNotDisplayed();
            mainPage.Validate().VerifyProfileButtonIsDisplayed();
            mainPage.Validate().VerifyProfileUserIsLoggedIn(newRegisteredUser.Email);
        }
    }
}
