using Microsoft.EntityFrameworkCore;
using Notee.Data;
using Notee.Shared.Entities;
using Notee.Shared.Entities.DTO;

namespace Notee.Services
{

    public interface INoteService
    {
        public Task<NoteToRetrieveDTO> CreateAsync(NoteToCreateDTO noteToCreate);

        public Task<NoteToRetrieveDTO?> GetAsync(int id);
    }

    public class NoteService : INoteService
    {
        private ApplicationDbContext _context;

        public NoteService(ApplicationDbContext context)
        {

            _context = context;
        }

        public async Task<NoteToRetrieveDTO> CreateAsync(NoteToCreateDTO noteToCreate)
        {
            {
                Note note = new();

                note.Title = noteToCreate.Title;
                note.Body = noteToCreate.Body;

                await _context.AddAsync(note);
                await _context.SaveChangesAsync();

                return new NoteToRetrieveDTO { Title = noteToCreate.Title, Body = noteToCreate.Body };
            }
        }

        public async Task<NoteToRetrieveDTO?> GetAsync(int id)
        {
            NoteToRetrieveDTO? noteDto = await _context.Notes.Where(x => x.Id == id).Select(x => new NoteToRetrieveDTO
            {
                Title = x.Title,
                Body = x.Body
            }).FirstOrDefaultAsync();

            return noteDto ?? null ;
        }
    }
}
