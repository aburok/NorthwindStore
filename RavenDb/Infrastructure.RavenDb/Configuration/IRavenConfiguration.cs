namespace Infrastructure.RavenDb.Configuration
{
    public interface IRavenConfiguration
    {
        string Url { get; }

        string Database { get; }
    }
}
