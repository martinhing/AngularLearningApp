using AngularLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularLearningApp.Services
{
    public interface IAuthenticationService
    {
        AuthenticationResult Login(string userName);
    }
}
