using Ordering.Domain.Common;
using Ordering.Domain.Entites.Buyers;

namespace Ordering.Application.Repositories;

public interface IBuyerRepository : IRepository
{
    Task Add(Buyer buyer);
}
