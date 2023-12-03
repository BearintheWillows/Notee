using Notee.Data.Interfaces;

namespace Notee.Data
{
    public class Note  : IHasTimestamps
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string NoteText { get; set; } = string.Empty;
        public string UserId { get; set; }

        // IHasTimestamps
        public DateTime Added { get; set; }
        public DateTime? Deleted { get; set; }
        public DateTime? Modified { get; set; }
    }
}
