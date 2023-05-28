namespace Ordering.Domain.Common;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
