using MediatR;
using Ordering.Application.Repositories;
using Ordering.Domain.Entites.Buyers;

namespace Ordering.Application.Handlers.Commands.CheckoutOrder;

public class CheckoutOrderCommandHandler : IRequestHandler<CheckoutOrderCommand, int>
{
    private readonly IBuyerRepository buyerRepository;

    public CheckoutOrderCommandHandler(IBuyerRepository buyerRepository)
    {
        this.buyerRepository = buyerRepository ?? throw new ArgumentNullException(nameof(buyerRepository));
    }

    public Task<int> Handle(CheckoutOrderCommand notification, CancellationToken cancellationToken)
    {
        var buyer = new Buyer(notification.Order.UserName);
        buyerRepository.Add(buyer); // create buyer and get new id
        return buyerRepository.SaveChangesAsync();
    }
}
