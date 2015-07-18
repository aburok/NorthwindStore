namespace NorthwindStore.Infrastructure.RavenDb.Configuration
{
    public class InCodeRavenConfiguration : IRavenConfiguration
    {
        public string Url { get { return "http://localhost:8080"; }}
        public string Database { get { return "Northwind"; }}
    }
}