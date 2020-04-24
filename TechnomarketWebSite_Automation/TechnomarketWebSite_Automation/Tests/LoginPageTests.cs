﻿using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core;
using NUnit.Framework;
using TechnomarketWebSite_Automation.Models;
using TechnomarketWebSite_Automation.Factories;

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
    }
}
