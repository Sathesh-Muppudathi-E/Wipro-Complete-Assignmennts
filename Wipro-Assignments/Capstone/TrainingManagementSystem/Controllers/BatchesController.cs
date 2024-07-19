using Microsoft.AspNetCore.Mvc;
using TrainingManagementSystem.Models;
using TrainingManagementSystem.Services;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace TrainingManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchesController : ControllerBase
    {
        private readonly IBatchService _batchService;

        public BatchesController(IBatchService batchService)
        {
            _batchService = batchService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Batch>>> GetBatches()
        {
            return Ok(await _batchService.GetAllBatchesAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Batch>> GetBatch(int id)
        {
            var batch = await _batchService.GetBatchByIdAsync(id);
            if (batch == null)
            {
                return NotFound();
            }
            return Ok(batch);
        }

        [HttpPost]
        public async Task<ActionResult<Batch>> PostBatch(Batch batch)
        {
            await _batchService.AddBatchAsync(batch);
            return CreatedAtAction("GetBatch", new { id = batch.ID }, batch);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBatch(int id, Batch batch)
        {
            if (id != batch.ID)
            {
                return BadRequest();
            }

            await _batchService.UpdateBatchAsync(batch);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBatch(int id)
        {
            await _batchService.DeleteBatchAsync(id);
            return NoContent();
        }
    }
}