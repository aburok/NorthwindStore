using NorthwindStore.Common.Commands;
using NorthwindStore.DataAccess.Order;

namespace NorthwindStore.BusinessLogic.Commands.Order
{
    public class MakeOrderCommandHandler : ICommandHandler<MakeOrderCommand>
    {
        private readonly IOrderRepository _repository;

        public MakeOrderCommandHandler(IOrderRepository repository)
        {
            _repository = repository;
        }

        public CommandResult Handle(MakeOrderCommand command)
        {
            _repository.GetOrderListById(command.ProdutIdList);

            return new CommandResult();
        }
    }
}