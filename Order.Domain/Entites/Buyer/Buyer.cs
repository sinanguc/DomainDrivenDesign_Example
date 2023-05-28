using Ordering.Domain.Common;

namespace Ordering.Domain.Entites.Buyers;

public class Buyer : BaseEntity
{
    public string UserName { get; private set; }

    public Buyer(string userName)
    {
        UserName = userName;
    }
}
