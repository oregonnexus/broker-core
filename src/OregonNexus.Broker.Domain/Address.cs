namespace OregonNexus.Broker.Domain;

public class Address : BaseEntity, IAggregateRoot
{
    public string StreetNumberName { get; set; } = default!;
    public string City { get; set; } = default!;
    public string StateAbbreviation { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
}
