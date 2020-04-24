using TechnomarketWebSite_Automation.Pages.MainPage;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TechnomarketWebSite_Automation.Core
{
    public class BasePageValidator<M>
        where M : BasePageElementMap, new()
    {

        protected M Map
        {
            get
            {
                return new M();
            }
        }
        

    }
}
