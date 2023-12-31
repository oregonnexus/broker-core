// Copyright: 2023 Education Nexus Oregon
// Author: Makoa Jacobsen, makoa@makoajacobsen.com

using System.Text.Json;
using System.Xml.Linq;

namespace OregonNexus.Broker.Domain;

public class PayloadContent : BaseEntity, IAggregateRoot
{
    public Guid MessageId { get; set; }
    public Message? Message { get; set; }
    public string? ContentType { get; set; }
    public byte[]? BlobContent { get; set; }
    public JsonDocument? JsonContent { get; set; }
    public XElement? XmlContent { get; set; }
}