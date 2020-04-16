using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmstudio.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
        }
        public DbSet<FilmModel> AllFilms { get; set; }

        public DbSet<FilmStudioModel> FilmStudio { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<FilmStudioModel>().HasData(new FilmStudioModel { StudioId = 1, StudioName = "Best buy" });
            modelBuilder.Entity<FilmStudioModel>().HasData(new FilmStudioModel { StudioId = 2, StudioName = "Cheese cakes" });
            modelBuilder.Entity<FilmStudioModel>().HasData(new FilmStudioModel { StudioId = 3, StudioName = "Seasonal pies" });

            //seed pies

            modelBuilder.Entity<FilmModel>().HasData(new FilmModel
            {
                FilmId = 1,
                Name = "Into the blue",
                Price = 121,
                StudioId = 1

            });
            modelBuilder.Entity<FilmModel>().HasData(new FilmModel
            {
                FilmId = 2,
                Name = "Deep blue see",
                Price = 129,
                StudioId = 2
            });
            modelBuilder.Entity<FilmModel>().HasData(new FilmModel
            {
                FilmId = 3,
                Name = "Speed",
                Price = 124,
                StudioId = 3

            });
        }
    }
}