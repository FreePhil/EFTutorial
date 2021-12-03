using EFTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFTutorial.Contexts
{
    public class TutorialContext: DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options): base(options) {}
        
        public DbSet<User> Users { get; set; }
    }
}