using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Employment_Project.Model;

namespace API_Employment_Project.Data
{
    public class Database : DbContext
    {
        public Database (DbContextOptions<Database> options)
            : base(options)
        {
        }

        public DbSet<API_Employment_Project.Model.Employment> Employment { get; set; }
    }
}
