using FinanceTracker.Contract.Ledger.Account;
using FinanceTracker.Contract.Ledger.Activity;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateAccount([FromBody] CreateAccountRequest request)
        {
            // Logic to create a new account
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAccounts()
        {
            // Logic to get all accounts
            return Ok();
        }

        [HttpGet("{accountId}")]
        public IActionResult GetAccount(Guid accountId)
        {
            // Logic to get a specific account
            return Ok();
        }

        [HttpPut("{accountId}")]
        public IActionResult UpdateAccount(Guid accountId, [FromBody] UpdateAccountRequest request)
        {
            // Logic to update an account
            return Ok();
        }

        [HttpDelete("{accountId}")]
        public IActionResult DeleteAccount(Guid accountId)
        {
            // Logic to delete an account
            return Ok();
        }

        [HttpPost("{accountId}/Deposit")]
        public IActionResult Deposit(Guid accountId, [FromBody] TransactMoneyRequest request)
        {
            // Logic to record deposit (money credited) for the account
            return Ok();
        }

        [HttpPost("{accountId}/Withdraw")]
        public IActionResult Withdraw(Guid accountId, [FromBody] TransactMoneyRequest request)
        {
            // Logic to record withdrawal (money debited) for the account
            return Ok();
        }

        [HttpPost("{accountId}/Transfer")]
        public IActionResult Transfer(Guid accountId, [FromBody] TransferMoneyRequest request)
        {
            // Logic to record transfer
            return Ok();
        }
    }
}
