using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApi_SYSBA
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// Registro de las areas y del router del web api
        /// </summary>
        protected void Application_Start()
        {
            Areas.HelpPage.HelpPageAreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
