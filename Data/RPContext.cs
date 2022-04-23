using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RPContext : DbContext
    {
        public RPContext(DbContextOptions<RPContext> options) : base(options)
        {
        }

        public DbSet<RPState> RPStates { get; set;}
    }
}