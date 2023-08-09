using _MaksKorz.Models;
using Microsoft.EntityFrameworkCore;

namespace _MaksKorz
{
	public class AplicationDbContext:DbContext
	{
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Album> albums { get; set; }  
        public DbSet<Song> songs { get; set; }
    }
}
