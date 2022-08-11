using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmpresariosBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EmpresariosBlazor.Models.Product> Product { get; set; }
        public DbSet<EmpresariosBlazor.Models.MovementByProduct> MovementByProduct { get; set; }
    }
}