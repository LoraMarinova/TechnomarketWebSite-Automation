using System;
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
        public void Test1()
        {
            Assert.True(true);
        }
    }
}
