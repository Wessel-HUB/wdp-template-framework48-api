using __ProjectName__.API.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace __ProjectName__.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(config => 
            {
                WebApiConfig.Register(config);
                AutofacConfig.Register(config);
            });
        }
    }
}
