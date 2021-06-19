using Homework12.Entities;
using Microsoft.EntityFrameworkCore;

namespace Homework12.DAO
{
    
   public class OrderContext: DbContext
    {

        public OrderContext(DbContextOptions<OrderContext> options) : base(options) {
            this.Database.EnsureCreated();
        }
        public DbSet<Cargo> Cargos { get; set; } 
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Client> clients { get; set; }

        public DbSet<Order> orders { get; set; }
    }
}
