using aspnet_exam_movie.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnet_exam_movie.Models 
{ 
    public class MyDbContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./mydb.db");
        } 

    }
}