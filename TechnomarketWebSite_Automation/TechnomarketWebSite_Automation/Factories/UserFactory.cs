using System;
using System.Collections.Generic;
using System.Text;
using TechnomarketWebSite_Automation.Core.Utilities;
using TechnomarketWebSite_Automation.Models;

namespace TechnomarketWebSite_Automation.Factories
{
    public class UserFactory
    {
        private const string dateTimeFormatSeconds = "ddMMyy-HHmmss";
        private const string SalutationOfMaleUser = "Господин";
        private const string SalutationOfFemaleUser = "Госпожа";
        private RandomValuesGenerator generator;
        private string dateTimeNow;

        public UserFactory()
        {
            this.generator = new RandomValuesGenerator();
            this.dateTimeNow = DateTime.Now.ToString(dateTimeFormatSeconds);
        }

        public User CreateUser(string gender, bool validBirthDate)
        {
            User user = new User();
            user.Email = generator.GenerateEmail(dateTimeNow);
            user.Password = generator.GeneratePassword(dateTimeNow);
            if (gender.ToLower() == "male")
            {
                user.Salutation = SalutationOfMaleUser;
            }
            else
            {
                user.Salutation = SalutationOfFemaleUser;
            }           
            user.FirstName = generator.GenerateFirstName(dateTimeNow);
            user.LastName = generator.GenerateLastName(dateTimeNow);
            if (validBirthDate)
            {
                user.Birthdate = generator.GenerateValidBirthDate();
            }
            else
            {
                user.Birthdate = generator.GenerateInvalidBirthDate();
            }        
            
            user.ResivePromotionInfo = true;
            user.AgreeToProcessPersonalData = true;
            user.AcceptTerms = true;
            return user;
        }       
    }
}
