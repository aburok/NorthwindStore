using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Common.Cache.HttpContext;
using Newtonsoft.Json.Serialization;
using NorthwindStore.BusinessLogic.Commands;
using NorthwindStore.DataAccess.RavenDb;
using NorthwindStore.Infrastructure.RavenDb;

namespace NorthwindStore.Services.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var config = GlobalConfiguration.Configuration;

            var container = new ServiceControllerActivator(config);
            IoCRegister.InitServiceLocator(container);

            config.Services.Replace(typeof(IHttpControllerActivator), container);

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = 
                new DefaultContractResolver(){IgnoreSerializableAttribute = true};
        }
    }
}
