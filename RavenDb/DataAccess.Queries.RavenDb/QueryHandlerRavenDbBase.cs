using Common.Queries;
using Infrastructure.RavenDb.Configuration;
using Raven.Client;
using Raven.Client.Document;

namespace DataAccess.Queries.RavenDb
{
    public abstract class QueryHandlerRavenDbBase<TQuery, TResult>
        where TResult : IQueryResult
        where TQuery : IQuery
    {
        private readonly IRavenConfiguration _configuration;

        protected TQuery Query { get; set; }

        protected QueryHandlerRavenDbBase(IRavenConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected TResult ExecuteQuery()
        {
            using (IDocumentStore store = new DocumentStore
            {
                Url = _configuration.Url,
                DefaultDatabase = _configuration.Database
            })
            {
                store.Initialize();

                using (var session = store.OpenSession())
                {
                    return GetQuery(session);
                }
            }
        }

        protected abstract TResult GetQuery(IDocumentSession session);
    }
}