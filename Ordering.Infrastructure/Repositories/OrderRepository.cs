using Ordering.Application.Repositories;

namespace Ordering.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task<int> SaveChangesAsync()
    {
        return Task.FromResult(1);
    }
}
