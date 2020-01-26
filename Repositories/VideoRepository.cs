using Microsoft.EntityFrameworkCore;
using VideoAPI.Models;

namespace VideoAPI.Repositories
{
    public class VideoRepository : DbContext
    {
        public VideoRepository(DbContextOptions<VideoRepository> options) : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
    }
}
