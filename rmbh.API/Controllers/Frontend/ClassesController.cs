using Microsoft.AspNetCore.Mvc;
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
    }
}
