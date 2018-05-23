using AngularLearningApp.MessageHandlers;
using System.Web.Http;

namespace AngularLearningApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.MessageHandlers.Add(new HourStartMessageHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{userName}",
                defaults: new { userName = RouteParameter.Optional }
            );
        }
    }
}
