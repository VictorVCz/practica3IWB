using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Framework> Frameworks { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}