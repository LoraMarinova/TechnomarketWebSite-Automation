using System;
using System.Collections.Generic;
using System.Text;

namespace TechnomarketWebSite_Automation.Models
{
    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Salutation { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Birthdate { get; set; }

        public bool ResivePromotionInfo { get; set; }

        public bool AgreeToProcessPersonalData { get; set; }

        public bool AcceptTerms{ get; set; }
    }
}
