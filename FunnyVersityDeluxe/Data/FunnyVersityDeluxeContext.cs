using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FVD.Domain;

namespace FunnyVersityDeluxe.Models
{
    public class FunnyVersityDeluxeContext : DbContext
    {
        public FunnyVersityDeluxeContext (DbContextOptions<FunnyVersityDeluxeContext> options)
            : base(options)
        {
        }

        public DbSet<FVD.Domain.Professor> Professor { get; set; }

        public DbSet<FVD.Domain.Course> Course { get; set; }
    }
}
