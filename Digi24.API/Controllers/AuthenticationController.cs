using Digi24.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Digi24.API.Controllers
{
    [RoutePrefix("api/Authentication")]
    public class AuthenticationController : ApiController
    {
        public AuthenticationController()
        {

        }


        [HttpPost]
        [Route("RegisterUser")]
        public HttpResponseMessage RegisterUser(UserRegistrationViewModel registrationData)
        {
            
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
