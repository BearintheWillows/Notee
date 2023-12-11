using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notee.Shared.Entities.DTO
{
    public class NoteToRetrieveDTO
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string? Body { get; set; }
    }
}
