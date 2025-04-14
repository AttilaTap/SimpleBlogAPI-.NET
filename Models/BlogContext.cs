using Microsoft.EntityFrameworkCore;

namespace SimpleBlogAPI.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<Post> Posts => Set<Post>();
    }
}