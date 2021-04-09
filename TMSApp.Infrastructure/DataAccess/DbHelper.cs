using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMSApp.Application.DTO;

namespace TMSApp.Infrastructure.DataAccess
{
    public class DbHelper : DbContext
    {


        public DbHelper(DbContextOptions<DbHelper> options):base(options)
        {
            Database.EnsureCreated();

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlite(@"Data Source = TMS.db;");
        }
        public DbSet<TMSDto> TMSDto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TMSDto>().HasData(
            //new TMSDto() { TaskName = "TaskName", TaskGroup = 1,TaskID=1},
            //new TMSDto() { TaskName = "TaskName2", TaskGroup = 2,TaskID =2}
            //);
            modelBuilder.Entity<TMSDto>().HasKey(s => s.TaskID);
            base.OnModelCreating(modelBuilder);

        }
    }
}
