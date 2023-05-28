using Ordering.Application.Repositories;
using Ordering.Domain.Entites.Buyers;

namespace Ordering.Infrastructure.Repositories;

public class BuyerRepository : IBuyerRepository
{
    public Task Add(Buyer buyer)
    {
        return Task.CompletedTask;
    }

    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
