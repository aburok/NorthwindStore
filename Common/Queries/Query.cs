namespace Common.Queries
{
    public class Query : IQuery
    {
        public Query()
        {
            ResultLimit = 100;
            Take = 10;
            Skip = 0;
        }

        public int ResultLimit { get; set; }

        public int Take { get; protected set; }

        public int Skip { get; protected set; }
    }
}