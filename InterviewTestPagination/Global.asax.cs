using System;
using System.Web.Http;

namespace InterviewTestPagination
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }
    }
}
