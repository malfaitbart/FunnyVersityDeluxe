using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Domain
{
    public class FVDContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }

        public FVDContext(DbContextOptions<FVDContext> options) : base(options)
        {

        }
    }
}
