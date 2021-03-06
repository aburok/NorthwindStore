﻿using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Services.Order;

namespace NorthwindStore.Services
{
    public class ModuleInitialization : IModuleInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IOrderApiService, OrderApiService>();
        }

        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
        {
            Initialize(serviceLocator);
        }
    }
}