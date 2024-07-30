using _06Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Project.DataAccessLayer.Context.EF
{
    public class EfDbContext :DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<MealTime> MealTimes { get; set; }
        public DbSet<PortionSize> PortionSizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserFood> UserFoods { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Group3DietProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PortionSize>().HasKey(p => p.Id);
            modelBuilder.Entity<MealTime>().HasKey(p => p.Id);
            modelBuilder.Entity<Food>().HasKey(p => p.Id);
            modelBuilder.Entity<User>().HasKey(p => p.Id);


            modelBuilder.Entity<PortionSize>().HasData(
                new PortionSize { Id=1,PortionInGrams = 100,Created=DateTime.Now },
                new PortionSize { Id = 2, PortionInGrams = 120, Created = DateTime.Now },
                new PortionSize { Id = 3, PortionInGrams = 140, Created = DateTime.Now });
            
            modelBuilder.Entity<MealTime>().HasData(
                new MealTime { Id = 1, MealName = "Breakfast", Created = DateTime.Now },
                new MealTime { Id = 2, MealName = "Lunch", Created = DateTime.Now },
                new MealTime { Id = 3, MealName = "Dinner", Created = DateTime.Now });

            modelBuilder.Entity<Food>().HasData(
                new Food { Id = 1, Name = "Hamburger", Description = "120g meat with cheese", Calorie = 1000, Carbs = 500, Fats = 250, Protein = 250, Created = DateTime.Now },
                new Food { Id = 2, Name = "Pizza", Description = "Mixed pizza", Calorie = 1200, Carbs = 600, Fats = 300, Protein = 300, Created = DateTime.Now });
        }
    }
}
