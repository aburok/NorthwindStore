using System;
using Raven.Client;

namespace NorthwindStore.Infrastructure.RavenDb
{
    public interface IDocumentStoreProvider : IDisposable
    {
        IDocumentStore GetDocumentStore();
    }
}