using FinanceTracker.Contract.Ledger.Portfolio.Activity;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers
{
    [Route("api/Accounts/{accountId}/[controller]")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        [HttpGet("Summary")]
        public IActionResult GetPortfolioSummary(Guid accountId)
        {
            // Logic to get high level portfolio summary for the account
            Console.WriteLine("Summary for account: " + accountId);
            return Ok();
        }
    }
}
