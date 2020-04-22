using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TechnomarketWebSite_Automation.Core.Utilities
{
    public class RandomValuesGenerator
    {
        public RandomValuesGenerator()
        {   
        }      

        public string GenerateEmail(string dateTimeNow)
        {
            return $"FirstName{dateTimeNow}@yopmail.com";
        }

        public string GeneratePassword(string dateTimeNow)
        {
            return $"Pass{dateTimeNow}";
        }

        public string GenerateFirstName(string dateTimeNow)
        {
            return $"FirstName{dateTimeNow}";
        }

        public string GenerateLastName(string dateTimeNow)
        {
            return $"LastName{dateTimeNow}";
        }

        public string GenerateValidBirthDate()
        {
            Random random = new Random();
            int year = random.Next(1950,2000);
            int month = random.Next(1, 12);
            int day = random.Next(1, 28);
            return $"{month}.{day}.{year}";
        }

        public string GenerateInvalidBirthDate()
        {
            Random random = new Random();
            int year = random.Next(2005, 2019);
            int month = random.Next(1, 12);
            int day = random.Next(1, 28);
            return $"{month}.{day}.{year}";
        }
    }
}
