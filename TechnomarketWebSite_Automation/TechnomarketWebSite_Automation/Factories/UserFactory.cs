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

        public User CreateUserMaleWithCorrectBirthDate()
        {
            User user = new User();
            user.Email = generator.GenerateEmail(dateTimeNow);
            user.Password = generator.GeneratePassword(dateTimeNow);
            user.Salutation = SalutationOfMaleUser;
            user.FirstName = generator.GenerateFirstName(dateTimeNow);
            user.LastName = generator.GenerateLastName(dateTimeNow);
            user.Birthdate = generator.GenerateCorrectBirthDate();
            user.ResivePromotionInfo = true;
            user.AgreeToProcessPersonalData = true;
            user.AcceptTerms = true;
            return user;
        }

        public User CreateUserMaleWithIncorrectBirthDate()
        {
            User user = new User();
            user.Email = generator.GenerateEmail(dateTimeNow);
            user.Password = generator.GeneratePassword(dateTimeNow);
            user.Salutation = SalutationOfMaleUser;
            user.FirstName = generator.GenerateFirstName(dateTimeNow);
            user.LastName = generator.GenerateLastName(dateTimeNow);
            user.Birthdate = generator.GenerateIncorrectBirthDate();
            user.ResivePromotionInfo = true;
            user.AgreeToProcessPersonalData = true;
            user.AcceptTerms = true;
            return user;
        }

        public User CreateUserFemaleWithCorrectBirthDate()
        {
            User user = new User();
            user.Email = generator.GenerateEmail(dateTimeNow);
            user.Password = generator.GeneratePassword(dateTimeNow);
            user.Salutation = SalutationOfFemaleUser;
            user.FirstName = generator.GenerateFirstName(dateTimeNow);
            user.LastName = generator.GenerateLastName(dateTimeNow);
            user.Birthdate = generator.GenerateCorrectBirthDate();
            user.ResivePromotionInfo = true;
            user.AgreeToProcessPersonalData = true;
            user.AcceptTerms = true;
            return user;
        }

        public User CreateUserFemaleWithIncorrectBirthDate()
        {
            User user = new User();
            user.Email = generator.GenerateEmail(dateTimeNow);
            user.Password = generator.GeneratePassword(dateTimeNow);
            user.Salutation = SalutationOfFemaleUser;
            user.FirstName = generator.GenerateFirstName(dateTimeNow);
            user.LastName = generator.GenerateLastName(dateTimeNow);
            user.Birthdate = generator.GenerateIncorrectBirthDate();
            user.ResivePromotionInfo = true;
            user.AgreeToProcessPersonalData = true;
            user.AcceptTerms = true;
            return user;
        }
    }
}
