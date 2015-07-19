using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using NorthwindStore.Common.ServiceLocation;
using StructureMap;

namespace NorthwindStore.Services.WebApi
{
    public class ServiceControllerActivator : IHttpControllerActivator,
        IServiceLocator
    {
        readonly Lazy<IContainer> _container = new Lazy<IContainer>(() =>
        {
            return new Container(c => c.AddRegistry<DefaultRegistry>());
        });

        public ServiceControllerActivator(HttpConfiguration configuration)
        {

        }

        public IHttpController Create(HttpRequestMessage request
            , HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var controller =
                _container.Value.GetInstance(controllerType) as IHttpController;
            return controller;
        }

        public void Dispose()
        {
            _container.Value.Dispose();
        }

        public object GetInstance(Type type)
        {
            return _container.Value.GetInstance(type);
        }

        public IEnumerable<object> GetInstances(Type type)
        {
            return _container.Value.GetAllInstances(type).Cast<object>();
        }

        public void ForUse(Type forType, Type useType)
        {
            _container.Value.Configure(x => x.For(forType).Use(useType));
        }
    }
}