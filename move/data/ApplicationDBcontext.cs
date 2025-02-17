using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using move.Models;

namespace move.data
{
    public class ApplicationDBcontext : DbContext
    {
        public DbSet<mooove> Moooves { get; set; }
        public DbSet<categury> categuries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=move;Integrated Security=True;TrustserverCertificate=True");
        }
        }
    }
  
