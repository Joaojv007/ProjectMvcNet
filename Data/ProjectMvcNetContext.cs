using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMvcNet.Models;

namespace ProjectMvcNet.Data
{
    public class ProjectMvcNetContext : DbContext
    {
        public ProjectMvcNetContext (DbContextOptions<ProjectMvcNetContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
