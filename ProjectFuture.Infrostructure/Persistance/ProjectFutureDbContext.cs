using Microsoft.EntityFrameworkCore;
using ProjectFuture.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFuture.Infrostructure.Persistance
{
    public class ProjectFutureDbContext : DbContext
    {
        public ProjectFutureDbContext(DbContextOptions<ProjectFutureDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
