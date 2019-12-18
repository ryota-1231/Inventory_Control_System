using Microsoft.EntityFrameworkCore;
using Inventory_Control_System.Models;
namespace Inventory_Control_System.Data
{
    public class Inventory_Control_SystemContext : DbContext
    {
        public Inventory_Control_SystemContext(DbContextOptions<Inventory_Control_SystemContext> options)
           : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
    }
}