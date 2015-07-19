using NorthwindStore.BusinessLogic.Commands.Order;
using NorthwindStore.Common.Commands;
using NorthwindStore.Common.ServiceLocation;

namespace NorthwindStore.BusinessLogic.Commands
{
    public class CommandsModuleInitialization : IModuleInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<
                ICommandHandler<MakeOrderCommand>,
                MakeOrderCommandHandler>();
        }

        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
        {
            Initialize(serviceLocator);
        }
    }
}