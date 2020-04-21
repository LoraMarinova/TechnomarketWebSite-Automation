
namespace TechnomarketWebSite_Automation.Core
{
    public class BasePage<M>
       where M : BasePageElementMap, new()
    {
        protected readonly string url;

        public BasePage(string url)
        {
            this.url = url;
        }

        protected M Map
        {
            get
            {
                return new M();
            }
        }

        public void Navigate()
        {
            Driver.Browser.Navigate().GoToUrl(this.url);
        }
    }

    public class BasePage<M, V> : BasePage<M>
        where M : BasePageElementMap, new()
        where V : BasePageValidator<M>, new()
    {
        public BasePage(string url)
            : base(url)
        {
        }

        public V Validate()
        {
            return new V();
        }

        public string GetTitleOfPage()
        {
            return Driver.Browser.Title;
        }
    }

}
