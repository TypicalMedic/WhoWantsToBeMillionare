using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionare
{
    public class qq
    {
        string question { get; set; }
        string q1 { get; set; }
        string q2 { get; set; }
        string q3 { get; set; }
        string q4 { get; set; }
        int answer { get; set; }
        int lv { get; set; }
    }
    public class qqqContext : DbContext
    {
        public DbSet<qq> qqs { get; set; }

        public string DbPath { get; }

        public qqqContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
