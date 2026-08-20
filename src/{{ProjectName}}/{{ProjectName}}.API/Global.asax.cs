using __ProjectName__.API.App_Start;
using Serilog;
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
            SerilogConfig.Configure();

            Log.Information("WDP API is starting.");

            GlobalConfiguration.Configure(config => 
            {
                WebApiConfig.Register(config);
                AutofacConfig.Register(config);
            });

            Log.Information("WDP API started successfully");
        }
    }
}
