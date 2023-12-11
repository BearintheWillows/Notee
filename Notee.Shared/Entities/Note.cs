using Notee.Interfaces;

namespace Notee.Shared.Entities
{
    public class Note : IHasTimestamps
    {
        public int Id { get; set; }


        public string Title { get; set; } = string.Empty;

        public string? Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }

    }
}
