using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Notee.Interfaces;
using Notee.Shared.Entities;

namespace Notee.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.Tracked += UpdateTimestamps;
            ChangeTracker.StateChanged += UpdateTimestamps;
        }



        public DbSet<Note> Notes { get; set; }

        private static void UpdateTimestamps(object sender, EntityEntryEventArgs e)
        {
            if (e.Entry.Entity is IHasTimestamps entityWithTimestamps)
                switch (e.Entry.State)
                {
                    case EntityState.Deleted:
                        entityWithTimestamps.Deleted = DateTime.UtcNow;
                        Console.WriteLine($"Stamped for delete: {e.Entry.Entity}");
                        break;
                    case EntityState.Modified:
                        entityWithTimestamps.Modified = DateTime.UtcNow;
                        Console.WriteLine($"Stamped for update: {e.Entry.Entity}");
                        break;
                    case EntityState.Added:
                        entityWithTimestamps.Created = DateTime.UtcNow;
                        Console.WriteLine($"Stamped for insert: {e.Entry.Entity}");
                        break;
                }
        }
    }
}
