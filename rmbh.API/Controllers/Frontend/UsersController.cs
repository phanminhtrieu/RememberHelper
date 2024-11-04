using Microsoft.AspNetCore.Mvc;
using rmbh_backoffice.MVC.Models.Services.Users;

namespace rmbh.API.Controllers.Frontend
{
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService) 
        { 
            _userService = userService;
        }


        /// <summary>
        /// Get all learners by class id
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpGet("class/{classId}")]
        public async Task<IActionResult> GetAllLearnersByClassId(int classId)
        {
            var classes = await _userService.GetAllLearnersByClassId(classId);

            if (classes == null || !classes.Any())
            {
                return NotFound();
            }
            return Ok(classes);
        }
    }
}
