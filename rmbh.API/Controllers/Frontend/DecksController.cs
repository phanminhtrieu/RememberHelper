using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rmbh_backoffice.MVC.Models.Services.Decks;

namespace rmbh.API.Controllers.Frontend
{
    public class DecksController : BaseController
    {
        private readonly IDeckService _deckService;

        public DecksController(IDeckService deckService)
        {
            _deckService = deckService;
        }

        /// <summary>
        /// Get all decks by class id
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpGet("class/{classId}")]
        public async Task<IActionResult> GetAllDecksByClassId(int classId)
        {
            var classes = await _deckService.GetAllDecksByClassId(classId);

            if (classes == null || !classes.Any())
            {
                return NotFound();
            }
            return Ok(classes);
        }
    }
}
