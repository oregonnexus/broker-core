using Ardalis.Specification;

namespace OregonNexus.Broker.Domain.Specifications;

public class PayloadContentsByMessageId : Specification<PayloadContent>, ISingleResultSpecification
{
  public PayloadContentsByMessageId(Guid messageId)
  {
    Query
        .Where(req => req.MessageId == messageId);
  }
}