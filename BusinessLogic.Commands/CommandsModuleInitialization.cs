using NorthwindStore.BusinessLogic.Commands.Order;
using NorthwindStore.Common.Commands;
using NorthwindStore.Common.ServiceLocation;

namespace NorthwindStore.BusinessLogic.Commands
{
    public class CommandsModuleInitialization : IModuleInitialization
    {
        public void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<
                ICommandHandler<MakeOrderCommand>,
                MakeOrderCommandHandler>();
        }
    }
}