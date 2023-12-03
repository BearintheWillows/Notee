using Microsoft.AspNetCore.Identity;
using Notee.Data.Interfaces;

namespace Notee.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser, IHasTimestamps
    {
        public DateTime Added { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
    }

}
