using AngularLearningApp.Filters;
using AngularLearningApp.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularLearningApp.Controllers
{
    [AllowAnonymous]
    public class DefaultController : ApiController
    {
        private IAuthenticationService _authenticationService;

        public DefaultController(IAuthenticationService AuthenticationService)
        {
            _authenticationService = AuthenticationService;
        }

        [HttpGet]
        [ContainsZFilter]
        public HttpResponseMessage Get(string userName)
        {
            var result = _authenticationService.Login(userName);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
