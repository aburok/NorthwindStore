namespace NorthwindStore.Common.Queries
{
    public interface IQueryHandler<in TQuery, out TResult> 
        where TQuery : IQuery
        where TResult : IQueryResult
    {
        TResult Handle(TQuery tQuery);
    }
}