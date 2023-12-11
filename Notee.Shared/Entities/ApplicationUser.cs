using Microsoft.AspNetCore.Identity;
using Notee.Interfaces;

namespace Notee.Shared.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser, IHasTimestamps
    {
        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }

        public DateTime? Deleted { get; set; }
    }

}
