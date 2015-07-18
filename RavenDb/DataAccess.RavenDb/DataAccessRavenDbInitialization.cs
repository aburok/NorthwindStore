using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.DataAccess.Company;
using NorthwindStore.DataAccess.Order;
using NorthwindStore.DataAccess.RavenDb.Company;
using NorthwindStore.DataAccess.RavenDb.Order;

namespace NorthwindStore.DataAccess.RavenDb
{
    public class DataAccessRavenDbInitialization : IModuleInitialization
    {
        public void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<ICompanyRepository, CompanyRepositoryRavenDb>();

            serviceLocator.ForUse<IOrderRepository, OrderRepositoryRavenDb>();
        }
    }
}
