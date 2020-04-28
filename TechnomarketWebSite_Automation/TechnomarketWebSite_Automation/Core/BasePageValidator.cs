using TechnomarketWebSite_Automation.Pages.MainPage;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace TechnomarketWebSite_Automation.Core
{
    public class BasePageValidator<M>
        where M : BasePageElementMap, new()
    {
        protected Actions action;
        public BasePageValidator()
        {
            this.action = new Actions(Driver.Browser);
        }
        protected M Map
        {
            get
            {
                return new M();
            }
        }

        public void VerifyPageIsLoadedUnderRequiredSeconds(long expectedMiliseconds, long actualMiliseconds)
        {
            Assert.True(actualMiliseconds < expectedMiliseconds, $"Page is loaded for {actualMiliseconds} miliseconds");
        }        
    }
}
