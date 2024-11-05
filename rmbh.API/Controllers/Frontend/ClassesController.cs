using Microsoft.AspNetCore.Mvc;
using rmbh_backoffice.MVC.Models.Dtos.Classes;
using rmbh_backoffice.MVC.Models.Services.Classes;

namespace rmbh.API.Controllers.Frontend
{
    /// <summary>
    /// Classes controller
    /// </summary>
    public class ClassesController : BaseController
    {
        private readonly IClassService _classService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        /// <summary>
        /// Get classes by user ID
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>List of classes</returns>
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetAllClassesByUserId(string userId)
        {
            var classes = await _classService.GetAllClassesByUserId(userId);

            if (classes == null || !classes.Any())
            {
                return NotFound(); 
            }
            return Ok(classes);
        }

        /// <summary>
        /// Add a new class
        /// </summary>
        /// <param name="request">Class creation request data</param>
        /// <returns>Response indicating the result of the operation</returns>
        [HttpPost("create")]
        public async Task<IActionResult> CreateAsync([FromBody] ClassRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid class data.");
            }

            try
            {
                await _classService.CreateAsync(request);
                return Ok("Class created successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Update class by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] ClassRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid class data.");
            }

            try
            {
                await _classService.UpdateAsync(id, request);
                return Ok("Class updated successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
