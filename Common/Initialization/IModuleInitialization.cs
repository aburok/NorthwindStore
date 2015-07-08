
using System;
using Common.ServiceLocation;

namespace Common.Initialization
{
    public interface IModuleInitialization
    {
        void Initialize(IServiceLocator serviceLocator);
    }

    public class ModuleInitializationAttribute : Attribute
    {
        public ModuleInitializationAttribute()
        {
            IsEnabled = true;
        }

        public bool IsEnabled { get; set; }
    }
}