using Microsoft.AspNetCore.Mvc;
using Notee.Services;
using Notee.Shared.Entities.DTO;

namespace Notee.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {

        private readonly INoteService _noteService;

        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NoteToRetrieveDTO>> GetNoteById(int id)
        {
            var note = await _noteService.GetAsync(id);

            return Ok(note);
        }

        [HttpPost]
        public async Task<ActionResult<NoteToRetrieveDTO>> PostNote(NoteToCreateDTO note)
        {
            var addedNote = await _noteService.CreateAsync(note);
            return Ok(addedNote);
        }
    }
}
