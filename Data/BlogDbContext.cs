using Microsoft.EntityFrameworkCore;
using Razor_App1.Models;

namespace Razor_App1.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) 
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
