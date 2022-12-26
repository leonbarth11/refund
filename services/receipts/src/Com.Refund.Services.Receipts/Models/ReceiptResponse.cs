using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Com.Refund.Services.Receipts.Models;

[DataContract]
public class ReceiptResponse
{
    [Required]
    [DataMember(Name = "id")]
    public Guid Id { get; set; }


    [Required]
    [DataMember(Name = "created")]
    public DateTime Created { get; set; }

    [Required]
    [DataMember(Name = "amount")]
    public decimal Amount { get; set; }

    [Required]
    [DataMember(Name = "currency")]
    public string Currency { get; set; }

    [Required]
    [DataMember(Name = "description")]
    public string Description { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("class ReceiptResponse {\n")
            .Append($"  \"{nameof(Id)}\": \"{Id}\"\n")
            .Append($"  \"{nameof(Created)}\": \"{Created}\"\n")
            .Append($"  \"{nameof(Amount)}\": \"{Amount}\"\n")
            .Append($"  \"{nameof(Currency)}\": \"{Currency}\"\n")
            .Append($"  \"{nameof(Description)}\": \"{Description}\"\n")
            .Append("}\n")
            .ToString();
    }
}
