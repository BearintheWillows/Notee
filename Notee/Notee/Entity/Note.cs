using Notee.Interfaces;

namespace Notee.Entity
{
    public class Note : IHasTimestamps
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string NoteText { get; set; } = string.Empty;

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }

        public DateTime? Deleted { get; set; }
        public int UserId { get; set; }
    }
}
