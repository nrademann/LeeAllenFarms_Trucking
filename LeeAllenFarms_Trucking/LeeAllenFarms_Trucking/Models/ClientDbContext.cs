using Microsoft.EntityFrameworkCore;

namespace LeeAllenFarms_Trucking.Models
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public ClientDbContext(DbContextOptions
            <ClientDbContext> options)
            : base(options)
        { }
    }
}
