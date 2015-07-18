namespace NorthwindStore.Common.ServiceLocation
{
    public interface IModuleInitialization
    {
        void Initialize(IServiceLocator serviceLocator);
    }
}