using System;
using System.Web.Mvc;
using Common.ServiceLocation;
using DataAccess.Product;
using DataAccess.Queries.RavenDb;
using DataAccess.RavenDb;
using Infrastructure.RavenDb;
using NorthwindStore.WebUI.DependencyResolution.StructureMap;

namespace NorthwindStore.WebUI.DependencyResolution
{
    public static class ServiceLocator
    {
        public static IServiceLocator Current
        {
            get { return StructuremapMvc.StructureMapDependencyScope; }
        }

        public static void Register()
        {
            QueryRavenDbInitialization.Initialize(Current);

            RavenDbInitialization.Initialize(Current);

            DataAccessRavenDbInitialization.Init(Current);

            Current.ForUse<IProductRepository, ProductRepository>();
        }
    }
}
