using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Com.Refund.Services.Receipts.Models;

[DataContract]
public class ReceiptsResponse
{
    [Required]
    [DataMember(Name = "receipts")]
    public List<ReceiptResponse> Receipts { get; set; }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("class ReceiptsResponse {\n")
            .Append($"  \"{nameof(Receipts)}\": \"{Receipts}\"\n")
            .Append("}\n")
            .ToString();
    }
}
