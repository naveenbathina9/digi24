using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Unity;
using Unity.Lifetime;
using Digi24.Repository.Infrastructure;
using Digi24.API.App_Start;
using Unity.Injection;
using Unity.Resolution;
using Digi24.Repository.Contracts;
using Digi24.Repository.Repositories;

namespace Digi24.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            //Unity configuration.
            config.DependencyResolver = new UnityResolver(new UnityContainer());

            // Web API routes
            config.MapHttpAttributeRoutes();

            //Enabled CORS
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
