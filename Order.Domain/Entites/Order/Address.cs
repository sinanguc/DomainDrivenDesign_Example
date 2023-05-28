using Ordering.Domain.Common;

namespace Ordering.Domain.Entites.Orders;

public class Address : ValueObject
{
    public string City { get; set; }
    public string Country { get; set; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return City;
        yield return Country;
    }
}
