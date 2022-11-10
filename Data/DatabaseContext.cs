using Microsoft.EntityFrameworkCore;
using MvcFriends.Models;

namespace MvcFriends.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>().HasData(
                new Friend{ Id =1,Name="GHOST",Email="ghost@gmail.com", Mobile="0000000"},
                new Friend{ Id =2,Name="MARY",Email="Mary@gmail.com", Mobile="1111111"},
                new Friend{ Id =3,Name="ROSE",Email="Rose@gmail.com", Mobile="2222222"}
            );
        }
    }
}

