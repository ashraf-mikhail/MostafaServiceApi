using System;
using System.Collections.Generic;
using System.Web.Http;

namespace AzureApi
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

           // var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
           // config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
           // //Default route
           // config.Routes.MapHttpRoute(
           //    name: "ApiControllerOnly",
           //    routeTemplate: "api/{controller}"
           //);
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
  }
}
