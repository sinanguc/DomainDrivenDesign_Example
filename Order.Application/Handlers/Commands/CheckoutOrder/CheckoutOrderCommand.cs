using MediatR;
using Ordering.Domain.Entites.Orders;

namespace Ordering.Application.Handlers.Commands.CheckoutOrder
{
    public class CheckoutOrderCommand : IRequest<int>
    {

        public string UserName { get; set; }

        public Order Order { get; set; }

        public CheckoutOrderCommand(string userName, Order order)
        {
            UserName = userName;
            Order = order ?? throw new ArgumentNullException(nameof(order));
        }
    }
}
