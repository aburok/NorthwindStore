using System;
using NorthwindStore.Infrastructure.RavenDb.Configuration;
using Raven.Client;
using Raven.Client.Document;

namespace NorthwindStore.Infrastructure.RavenDb
{
    public class RequestDocumentStoreProvider : IDocumentStoreProvider
    {
        private readonly IRavenConfiguration _configuration;

        private readonly Lazy<IDocumentStore> _instance;

        public RequestDocumentStoreProvider(IRavenConfiguration configuration)
        {
            _configuration = configuration;

            _instance = new Lazy<IDocumentStore>(() => GetDocumentStore(configuration));
        }

        public IDocumentStore GetDocumentStore()
        {
            return GetDocumentStore(_configuration);
        }

        private static IDocumentStore GetDocumentStore(IRavenConfiguration configuration)
        {
            var store = new DocumentStore()
            {
                Url = configuration.Url,
                DefaultDatabase = configuration.Database
            };

            store.Initialize();
            return store;
        }

        public void Dispose()
        {
            if (_instance.IsValueCreated && _instance.Value != null)
            {
                _instance.Value.Dispose();
            }
        }
    }
}