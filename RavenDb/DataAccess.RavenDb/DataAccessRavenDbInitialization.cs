using Common.ServiceLocation;
using DataAccess.Company;
using DataAccess.Order;
using DataAccess.RavenDb.Company;
using DataAccess.RavenDb.Order;

namespace DataAccess.RavenDb
{
    public static class DataAccessRavenDbInitialization
    {
        public static void Init(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<ICompanyRepository, CompanyRepositoryRavenDb>();

            serviceLocator.ForUse<IOrderRepository, OrderRepositoryRavenDb>();
        }
    }
}
