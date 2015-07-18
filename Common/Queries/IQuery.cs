using System.Collections.Generic;

namespace NorthwindStore.Common.Queries
{
    public interface IQuery
    {
    }

    public interface ICollectionQuery : IQuery
    {
        int ResultLimit { get; set; }

        int Take { get; }

        int Skip { get; }
    }

    public interface IQueryResult
    {

    }

    public abstract class QueryResult<TResult> : IQueryResult
    {
        public TResult Data { get; set; }
    }

    public abstract class CollectionQueryResult<TItem> : IQueryResult
    {
        public IEnumerable<TItem> Items { get; set; }

        public int TotalCount { get; set; }

        public int PageNumber { get; set; }

        public int ItemsPerPage { get; set; }
    }
}
