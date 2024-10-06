using EduHubAPI.CA.Infrastructure.FileManager.Models;
using Microsoft.EntityFrameworkCore;

namespace EduHubAPI.CA.Infrastructure.FileManager.Contexts
{
    public class FileManagerDbContext(DbContextOptions<FileManagerDbContext> options) : DbContext(options)
    {
        public DbSet<FileEntity> Files { get; set; }
    }
}
