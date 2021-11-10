using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoNetCore.Models;

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<DemoNetCore.Models.Employee> Employee { get; set; }

        public DbSet<DemoNetCore.Models.Person> Person { get; set; }

        public DbSet<DemoNetCore.Models.Product> Product { get; set; }

        public DbSet<DemoNetCore.Models.Student> Student { get; set; }
    }
