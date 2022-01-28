using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SchoolTourWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
               name: "WeatherInfoApi",
               routeTemplate: "api/{controller}/{activityN}",
               defaults: new { activityN = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
