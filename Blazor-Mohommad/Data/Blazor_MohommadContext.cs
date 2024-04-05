using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazor_Mohommad;

namespace Blazor_Mohommad.Data
{
    public class Blazor_MohommadContext : DbContext
    {
        public Blazor_MohommadContext (DbContextOptions<Blazor_MohommadContext> options)
            : base(options)
        {
        }

        public DbSet<Blazor_Mohommad.Student> Student { get; set; } = default!;
    }
}
