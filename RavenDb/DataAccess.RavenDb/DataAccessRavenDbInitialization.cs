using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ServiceLocation;
using DataAccess.Company;
using DataAccess.RavenDb.Company;

namespace DataAccess.RavenDb
{
    public static class DataAccessRavenDbInitialization
    {
        public static void Init(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<ICompanyRepository, CompanyRepositoryRavenDb>();
        }
    }
}
