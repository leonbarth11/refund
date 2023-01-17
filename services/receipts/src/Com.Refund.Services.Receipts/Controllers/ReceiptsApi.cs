using System.Text.Json;
using Com.Refund.Services.Receipts.Models;
using Microsoft.AspNetCore.Mvc;

namespace Com.Refund.Services.Receipts.Controllers;

[ApiController]
public class ReceiptsApiController : ControllerBase
{
    [HttpGet]
    [Route("/receipts")]
    [ProducesResponseType(statusCode: 200, type: typeof(ReceiptsResponse))]
    public async Task<IActionResult> ReceiptsGet()
    {
        const string exampleJson =
            "{\n  \"receipts\" : [ {\n    \"amount\" : 10.52,\n    \"created\" : \"2019-12-05T05:30:00+05:30\",\n    \"description\" : \"Uber ride to the restaurant\",\n    \"currency\" : \"EUR\",\n    \"id\" : \"d9bfe812-65d7-4b1d-9857-2fd3259fdfea\"\n  }, {\n    \"amount\" : 10.52,\n    \"created\" : \"2019-12-05T05:30:00+05:30\",\n    \"description\" : \"Uber ride to the restaurant\",\n    \"currency\" : \"EUR\",\n    \"id\" : \"d9bfe812-65d7-4b1d-9857-2fd3259fdfea\"\n  } ]\n}";

        var example = JsonSerializer.Deserialize<ReceiptsResponse>(exampleJson);

        return StatusCode(200, example);
    }

    [HttpPost]
    [Route("/receipts")]
    [Consumes("application/json")]
    [ProducesResponseType(statusCode: 201, type: typeof(ReceiptResponse))]
    public async Task<IActionResult> ReceiptsPost([FromBody] ReceiptRequest receiptRequest)
    {
        const string exampleJson =
            "{\n  \"amount\" : 10.52,\n  \"created\" : \"2019-12-05T05:30:00+05:30\",\n  \"description\" : \"Uber ride to the restaurant\",\n  \"currency\" : \"EUR\",\n  \"id\" : \"d9bfe812-65d7-4b1d-9857-2fd3259fdfea\"\n}";

        var example = JsonSerializer.Deserialize<ReceiptResponse>(exampleJson);

        return StatusCode(201, example);
    }
}
