using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Autopeças.EF;

namespace Autopeças.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Autopeças.EF.Peca> Peca { get; set; }
        public DbSet<Autopeças.EF.Cliente> Cliente { get; set; }
    }
}
