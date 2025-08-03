using FinanceTracker.Contract.Ledger.Budget;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateBudget([FromBody] CreateBudgetRequest request)
        {
            // Logic to create a new budget
            return Ok();
        }

        [HttpGet]
        public IActionResult GetBudgets()
        {
            // Logic to get all budgets
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBudget(Guid id)
        {
            // Logic to get a specific budget
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBudget(Guid id, [FromBody] UpdateBudgetRequest request)
        {
            // Logic to update a budget
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBudget(Guid id)
        {
            // Logic to delete a budget
            return Ok();
        }
    }
}
