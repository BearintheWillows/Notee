using Microsoft.EntityFrameworkCore;
using Notee.Services;
using Notee.Shared.Entities;
using Notee.Shared.Entities.DTO;
using System.Net.Http.Json;

namespace Notee.Client.Services
{

    public class ClientNoteService : INoteService
    {
        private readonly HttpClient _httpClient;

        public ClientNoteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NoteToRetrieveDTO> CreateAsync(NoteToCreateDTO noteToCreate)
        {
            {
                Note newNote = new Note() { Title = noteToCreate.Title, Body = noteToCreate.Body };


                var result = await _httpClient.PostAsJsonAsync("/api/note", newNote);

                return await result.Content.ReadFromJsonAsync<NoteToRetrieveDTO>();
            }
        }

        public async Task<NoteToRetrieveDTO?> GetAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<NoteToRetrieveDTO>($"/api/note/{id}");

            return result;
        }
    }
}
