using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Aplication.Models;

namespace API_Aplication.Data
{
    public class API_AplicationContext : DbContext
    {
        public API_AplicationContext (DbContextOptions<API_AplicationContext> options)
            : base(options)
        {
        }

        public DbSet<API_Aplication.Models.Recipe> Recipe { get; set; } = default!;
    }
}
