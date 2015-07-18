using System.Collections.Generic;
using NorthwindStore.Common.Commands;

namespace NorthwindStore.BusinessLogic.Commands.Order
{
    public class MakeOrderCommand : ICommand
    {
        public IEnumerable<string> ProdutIdList { get; set; }

        public string EmployeeId { get; set; }

        public string CompanyId { get; set; }

        public string ShipTo { get; set; }
    }
}
