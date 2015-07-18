using System;
using System.Collections.Generic;

namespace NorthwindStore.Common.ServiceLocation
{
    /// <summary>
    /// Generally avoid to use this directly in logic.
    /// Used for registering types & for MVC Dependency Resolver.
    /// </summary>
    public interface IServiceLocator : IDisposable
    {
        object GetInstance(Type type);

        IEnumerable<object> GetInstances(Type type);

        void ForUse(Type forType, Type useType);
    }
}