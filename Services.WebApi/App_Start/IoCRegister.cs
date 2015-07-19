using Common.Cache.HttpContext;
using NorthwindStore.BusinessLogic.Commands;
using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.DataAccess.RavenDb;
using NorthwindStore.Infrastructure.RavenDb;

namespace NorthwindStore.Services.WebApi
{
    public class IoCRegister
    {
        public static void InitServiceLocator(IServiceLocator serviceLocator)
        {
            CommandsModuleInitialization.Initialize(serviceLocator);

            DataAccessRavenDbInitialization.Initialize(serviceLocator);

            ModuleInitialization.Initialize(serviceLocator);

            RavenDbInitialization.Initialize(serviceLocator);

            CommonWebInitialization.Initialize(serviceLocator);
        }
    }
}