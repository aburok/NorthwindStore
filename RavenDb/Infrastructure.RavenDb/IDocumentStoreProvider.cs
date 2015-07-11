using System;
using Raven.Client;

namespace Infrastructure.RavenDb
{
    public interface IDocumentStoreProvider : IDisposable
    {
        IDocumentStore GetDocumentStore();
    }
}