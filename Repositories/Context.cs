using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<Child> Children { get; set ; }
        public DbSet<Parent> Parents { get; set ; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=ServerUsers;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
