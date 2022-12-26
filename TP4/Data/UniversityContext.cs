using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using TP4.Models;

namespace TP4.Data
{
    public class UniversityContext : DbContext 

    {

        public DbSet<Student> Students { get; set; }
        public static UniversityContext context;
        public static UniversityContext getInstance()
        {
            if (context == null)
                context = Instantiate_UniversityContext();
            return context;
        }
        private UniversityContext (DbContextOptions o) : base (o) 
        { 

        }
        private static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite(" Data Source =  C:\\Users\\Eya Ridene\\Desktop\\dotnet \\ database.db");
            // test
            Debug.WriteLine("une seul instance");

            return new UniversityContext(optionsBuilder.Options);
            
        }
    }
}