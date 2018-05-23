using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AngularLearningApp.MessageHandlers
{
    public class HourStartMessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (DateTime.Now.Minute < 5)
            {
                return request.CreateErrorResponse(HttpStatusCode.Unauthorized, "You are not authorized");
            }

            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}