namespace NorthwindStore.Common.Cache
{
    public interface ICache
    {
        bool IsInCache(string key);

        T Get<T>(string key) where T : class;

        void PutOrUpdate<T>(string key, T value);

        void Clear(string key);

        void Put<T>(string key, T value, int? cacheDurationInMinutes = null );
    }
}