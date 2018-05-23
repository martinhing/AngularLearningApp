using System;
using AngularLearningApp.Models;

namespace AngularLearningApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Login(string userName)
        {
            // Determine the greeting from the time of day
            var greeting = "";
            var hourOfDay = DateTime.Now.Hour;
            if (hourOfDay < 12)
            {
                greeting = "Good Morning";
            }
            else if(hourOfDay >= 12 && hourOfDay < 18)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }

            var result = new AuthenticationResult
            {
                Greeting = greeting + " " + userName
            };
            return result;
        }
    }
}